using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarsApp
{
    /// <summary>
    /// Interface de modification d'une activité
    /// </summary>
    public partial class ModificationActivite : BaseFenetre
    {
        private Activite activiteAModifier;
        private Journee journeeAModifier;
        private CalendrierMission cm;
        private Lieu lieu;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="j">Une journée</param>
        /// <param name="a">Une activité la journée</param>
        /// <param name="cm">L'interface graphique CalendrierMission</param>
        public ModificationActivite(Journee j, Activite a, CalendrierMission cm)
        {
            if (a.getHeureFin().getHeures() == 24 && a.getHeureFin().getMinutes() == 39)
                a.setHeureFin(new TimeMartien(0));

            InitializeComponent();

            if (finHeure.Value == 0 && finMinute.Value == 0)
            {
                finHeure.Value = 24;
                finMinute.Value = 40;
            }

            debutHeure.Maximum = finHeure.Value;

            lieu = new Lieu(0, 0);

            activiteAModifier = a;
            journeeAModifier = j;
            this.cm = cm;

            debutHeure.Value = activiteAModifier.getHeureDebut().getHeures();
            finHeure.Value = activiteAModifier.getHeureFin().getHeures();

            debutMinute.Value = activiteAModifier.getHeureDebut().getMinutes();
            finMinute.Value = activiteAModifier.getHeureFin().getMinutes();

            debutHeure.Minimum = debutHeure.Value;
            finHeure.Maximum = (finHeure.Value == 0) ? 24 : finHeure.Value;

            finHeure.Minimum = debutHeure.Value;


            foreach (Domaine d in CalendrierMission.domaines)
            {
                TreeNode tn = treeView.Nodes.Add(d.getNom());

                foreach (TypeActivite ta in d.getActivites())
                    tn.Nodes.Add(ta.getNom());
            }

            descriptionTB.Text = a.getDescription();

            if (a.isActiviteExterieure())
            {
                exterieurRadio.Checked = true;

                if (a.isExploration())
                    explorationRadio.Checked = true;
                else
                    experienceRadio.Checked = true;
            }
            else
                interieurRadio.Checked = true;

            treeView.ExpandAll();

            foreach (TreeNode tn in treeView.Nodes)
                foreach (TreeNode tnn in tn.Nodes)
                    if (tnn.Text.Equals(a.getNom()))
                        treeView.SelectedNode = tnn;

            lieuTB.Text = activiteAModifier.getLieu().ToString();
        }
        #endregion

        #region Evènements
        private void exterieurRadio_CheckedChanged(object sender, EventArgs e)
        {
            activiteExterieureGB.Enabled = (exterieurRadio.Checked) ? true : false;
            lieuGB.Enabled = (exterieurRadio.Checked) ? true : false;
            transportGB.Enabled = (exterieurRadio.Checked) ? true : false;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            String type = treeView.SelectedNode.Text;
            journeeAModifier.supprimerActivite(activiteAModifier);

            Activite a;

            if (exterieurRadio.Checked)
            {
                ITransport transport;

                if (vehiculeRadio.Checked)
                    transport = new Vehicule();
                else
                    transport = new Scaphandre();

                if (explorationRadio.Checked)
                    a = new ExplorationExterieure(new TypeActivite(type), descriptionTB.Text, new TimeMartien(0, (int)debutHeure.Value, (int)debutMinute.Value, 0), new TimeMartien(0, (int)finHeure.Value, (int)finMinute.Value, 0), lieu, transport);
                else
                    a = new ExperienceExterieure(new TypeActivite(type), descriptionTB.Text, new TimeMartien(0, (int)debutHeure.Value, (int)debutMinute.Value, 0), new TimeMartien(0, (int)finHeure.Value, (int)finMinute.Value, 0), lieu, transport);
            }
            else
                a = new Activite(new TypeActivite(type), descriptionTB.Text, new TimeMartien(0, (int)debutHeure.Value, (int)debutMinute.Value, 0), new TimeMartien(0, (int)finHeure.Value, (int)finMinute.Value, 0), new Lieu(0, 0));

            /* Découpage activité */
            if (activiteAModifier.getDuree().getTotalMinutes() == 10)
                journeeAModifier.ajouterActivite(a);
            else if (activiteAModifier.getDuree().getTotalMinutes() == 20)
            {
                if (activiteAModifier.getHeureDebut() < a.getHeureDebut())
                    activiteAModifier.setHeureFin(new TimeMartien(0, (int)debutHeure.Value, (int)debutMinute.Value, 0));
                else
                    activiteAModifier.setHeureDebut(new TimeMartien(0, (int)finHeure.Value, (int)finMinute.Value, 0));

                journeeAModifier.ajouterActivite(a);
                journeeAModifier.ajouterActivite(activiteAModifier);
            }
            else if (activiteAModifier.getDuree().getTotalMinutes() > 20)
            {
                if (activiteAModifier.getHeureDebut() < a.getHeureDebut()
                    && activiteAModifier.getHeureFin() > a.getHeureFin())
                {
                    Activite copie = (activiteAModifier.isActiviteExterieure()) ? null : new Activite(activiteAModifier);

                    if (copie == null && activiteAModifier.isExploration())
                        copie = new ExplorationExterieure((ExplorationExterieure) activiteAModifier);
                    else if (copie == null)
                        copie = new ExperienceExterieure((ExperienceExterieure) activiteAModifier);

                    activiteAModifier.setHeureFin(new TimeMartien(0, (int)debutHeure.Value, (int)debutMinute.Value, 0));
                    copie.setHeureDebut(new TimeMartien(0, (int)finHeure.Value, (int)finMinute.Value, 0));

                    journeeAModifier.ajouterActivite(copie);
                    journeeAModifier.ajouterActivite(activiteAModifier);
                }
                else if (activiteAModifier.getHeureDebut() < a.getHeureDebut()
                            && activiteAModifier.getHeureFin() == a.getHeureFin())
                {
                    activiteAModifier.setHeureFin(new TimeMartien(0, (int)debutHeure.Value, (int)debutMinute.Value, 0));
                    journeeAModifier.ajouterActivite(activiteAModifier);
                }
                else if (activiteAModifier.getHeureDebut() == a.getHeureDebut()
                            && activiteAModifier.getHeureFin() > a.getHeureFin())
                {
                    activiteAModifier.setHeureDebut(new TimeMartien(0, (int)finHeure.Value, (int)finMinute.Value, 0));
                    journeeAModifier.ajouterActivite(activiteAModifier);
                }

                journeeAModifier.ajouterActivite(a);
            }

            cm.miseAJourEdt(journeeAModifier);
            fermerFenetre();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SelectionCarte sc = new SelectionCarte(lieu, lieuTB);
            sc.Show();
        }

        private void duree_ValueChanged(object sender, EventArgs e)
        {
            if (finHeure.Value == 24)
                finMinute.Maximum = 40;
            else
                finMinute.Maximum = 60;

            if (debutHeure.Value == 24)
                debutMinute.Maximum = 40;
            else
                debutMinute.Maximum = 60;
        }
        #endregion
    }
}
