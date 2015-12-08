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
        private DetailHeure dh;
        private Lieu lieu;

        private TimeMartien heureDebutStatic;
        private TimeMartien heureFinStatic;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="j">Une journée</param>
        /// <param name="a">Une activité la journée</param>
        /// <param name="cm">L'interface graphique CalendrierMission</param>
        /// <param name="dh">L'interface graphique DetailHeure</param>
        public ModificationActivite(Journee j, Activite a, CalendrierMission cm, DetailHeure dh)
        {
            if (a.getHeureFin().getHeures() == 24 && a.getHeureFin().getMinutes() == 39)
                a.setHeureFin(new TimeMartien(0));

            InitializeComponent();
            this.dh = dh;

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

            finHeure.Minimum = (finHeure.Value == 0) ? 0 : debutHeure.Value;

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

            debutHeure.Maximum = finHeure.Maximum;

            heureDebutStatic = new TimeMartien(0, (int) debutHeure.Value, (int) debutMinute.Value, 0);
            heureFinStatic = new TimeMartien(0, (int) finHeure.Value, (int) finMinute.Value, 0);
        }
        #endregion

        #region Evènements
        /// <summary>
        /// Permet d'activer/désactiver les GroupBox en fonction du lieu de l'activité
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void exterieurRadio_CheckedChanged(object sender, EventArgs e)
        {
            activiteExterieureGB.Enabled = (exterieurRadio.Checked) ? true : false;
            lieuGB.Enabled = (exterieurRadio.Checked) ? true : false;
            transportGB.Enabled = (exterieurRadio.Checked) ? true : false;
        }

        /// <summary>
        /// Permet d'annuler les modifications
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void annuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Permet de procéder aux modifications
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void ok_Click(object sender, EventArgs e)
        {
            TimeMartien d = new TimeMartien(0, (int) debutHeure.Value, (int) debutMinute.Value, 0);
            TimeMartien f = new TimeMartien(0, (int) finHeure.Value, (int) finMinute.Value, 0);

            if (d < f || (d > f && f.Equals(new TimeMartien(0))))
            {
                String type = treeView.SelectedNode.Text;
                journeeAModifier.supprimerActivite(activiteAModifier);

                try
                {
                    lieu = new Lieu(int.Parse(lieuTB.Text.Split(';')[0]), int.Parse(lieuTB.Text.Split(';')[1]));
                }
                catch
                {
                    lieu = new Lieu(0, 0);
                }

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

                if (a.getDuree().getTotalMinutes() > 0)
                {
                    if (a.getHeureFin().getHeures() == 0 && a.getHeureFin().getMinutes() == 0 && a.getHeureFin().getSecondes() == 0)
                        a.setHeureFin(new TimeMartien(0, 24, 39, 59));

                    /* Découpage activité */
                    if (activiteAModifier.getHeureFin().getHeures() == 0 && activiteAModifier.getHeureFin().getMinutes() == 0 && activiteAModifier.getHeureFin().getSecondes() == 0)
                        activiteAModifier.setHeureFin(new TimeMartien(0, 24, 39, 59));

                    if (activiteAModifier.getDuree().getTotalMinutes() == 10 || activiteAModifier.getDuree().getTotalMinutes() == 9)
                        journeeAModifier.ajouterActivite(a);
                    else if (activiteAModifier.getDuree().getTotalMinutes() == 20 || activiteAModifier.getDuree().getTotalMinutes() == 19)
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
                                copie = new ExplorationExterieure((ExplorationExterieure)activiteAModifier);
                            else if (copie == null)
                                copie = new ExperienceExterieure((ExperienceExterieure)activiteAModifier);

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

                    if (a.getHeureFin().getHeures() == 24 && a.getHeureFin().getMinutes() == 39 && a.getHeureFin().getSecondes() == 59)
                        a.setHeureFin(new TimeMartien(0));

                    cm.miseAJourEdt(journeeAModifier);
                    dh.Close();
                    cm.ouvrirDernierDetailHeure();
                    fermerFenetre();
                }
                else
                {
                    errDuree.Text = "La durée de l'activité doit être d'au moins 10 minutes";
                    errDuree.Visible = true;
                }
            }
            else
            {
                errDuree.Text = "La date de début doit être inférieure à la date de fin";
                errDuree.Visible = true;
            }
        }

        /// <summary>
        /// Permet d'afficher la carte pour la sélection d'un lieu
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SelectionCarte sc = new SelectionCarte(lieu, lieuTB);
            sc.Show();
        }

        /// <summary>
        /// Permet de jouer avec les Max/Min pour l'heure 20h et > 39 minutes
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void duree_ValueChanged(object sender, EventArgs e)
        {
            if (heureDebutStatic != null && heureFinStatic != null)
            {
                if (debutHeure.Value == finHeure.Value)
                {
                    debutHeure.Maximum = finHeure.Value;
                    debutMinute.Value = (debutMinute.Value > finMinute.Value) ? finMinute.Value : debutMinute.Value;
                    debutMinute.Maximum = finMinute.Value;
                }
                else
                {
                    debutHeure.Maximum = (heureFinStatic.getHeures() == 0 && heureFinStatic.getMinutes() == 0) ? 24 : heureFinStatic.getHeures();
                    debutMinute.Maximum = 50;
                }
            }

            if (finHeure.Value == 24)
                finMinute.Maximum = 40;
            else
                finMinute.Maximum = 50;

            if (debutHeure.Value == 24)
                debutMinute.Maximum = 40;
            else
                debutMinute.Maximum = 50;

            String valDebut = debutMinute.Value.ToString();
            String valFin = finMinute.Value.ToString();

            debutMinute.Value = (debutMinute.Value - int.Parse(valDebut[valDebut.Length - 1].ToString()));
            finMinute.Value = (finMinute.Value - int.Parse(valFin[valFin.Length - 1].ToString()));
        }
        #endregion
    }
}
