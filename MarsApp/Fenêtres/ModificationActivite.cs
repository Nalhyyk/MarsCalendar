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
    public partial class ModificationActivite : BaseFenetre
    {
        private Activite activiteAModifier;
        private Journee journeeAModifier;
        private CalendrierMission cm;

        public ModificationActivite(Journee j, Activite a, CalendrierMission cm)
        {
            InitializeComponent();

            activiteAModifier = a;
            journeeAModifier = j;
            this.cm = cm;

            debutHeure.Value = activiteAModifier.getHeureDebut().getHeures();
            finHeure.Value = activiteAModifier.getHeureFin().getHeures();
            debutHeure.Minimum = debutHeure.Value;
            finHeure.Minimum = debutHeure.Value + 1;
            debutHeure.Maximum = finHeure.Value - 1;
            finHeure.Maximum = finHeure.Value;

            if (debutHeure.Minimum == 24)
                debutHeure.Minimum = 0;
            if (debutHeure.Maximum == 24)
                debutHeure.Maximum = 0;
            if (finHeure.Minimum == 24)
                finHeure.Minimum = 0;
            if (finHeure.Maximum == 24)
                finHeure.Maximum = 0;

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
        }

        private void exterieurRadio_CheckedChanged(object sender, EventArgs e)
        {
            activiteExterieureGB.Enabled = (exterieurRadio.Checked) ? true : false;
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
                if (explorationRadio.Checked)
                    a = new ExplorationExterieure(new TypeActivite(type), descriptionTB.Text, new TimeMartien((int)debutHeure.Value), new TimeMartien((int)finHeure.Value), new Lieu(0, 0));
                else
                    a = new ExperienceExterieure(new TypeActivite(type), descriptionTB.Text, new TimeMartien((int)debutHeure.Value), new TimeMartien((int)finHeure.Value), new Lieu(0, 0));
            else
                a = new Activite(new TypeActivite(type), descriptionTB.Text, new TimeMartien((int)debutHeure.Value), new TimeMartien((int)finHeure.Value), new Lieu(0, 0));

            if (activiteAModifier.getDuree().getHeures() == 1)
                journeeAModifier.ajouterActivite(a);
            else if (activiteAModifier.getDuree().getHeures() == 2)
            {
                if (activiteAModifier.getHeureDebut().getHeures() < a.getHeureDebut().getHeures())
                    activiteAModifier.setHeureFin(new TimeMartien((int)debutHeure.Value));
                else
                    activiteAModifier.setHeureDebut(new TimeMartien((int)finHeure.Value));

                journeeAModifier.ajouterActivite(a);
                journeeAModifier.ajouterActivite(activiteAModifier);
            }
            else if (activiteAModifier.getDuree().getHeures() > 2)
            {
                if (activiteAModifier.getHeureDebut().getHeures() < a.getHeureDebut().getHeures()
                    && activiteAModifier.getHeureFin().getHeures() > a.getHeureFin().getHeures())
                {
                    Activite copie = (activiteAModifier.isActiviteExterieure()) ? null : new Activite(activiteAModifier);

                    if (copie == null && activiteAModifier.isExploration())
                        copie = new ExplorationExterieure((ExplorationExterieure) activiteAModifier);
                    else if (copie == null)
                        copie = new ExperienceExterieure((ExperienceExterieure) activiteAModifier);

                    activiteAModifier.setHeureFin(new TimeMartien((int)debutHeure.Value));
                    copie.setHeureDebut(new TimeMartien((int)finHeure.Value));

                    journeeAModifier.ajouterActivite(copie);
                    journeeAModifier.ajouterActivite(activiteAModifier);
                }
                else if (activiteAModifier.getHeureDebut().getHeures() < a.getHeureDebut().getHeures()
                            && activiteAModifier.getHeureFin().getHeures() == a.getHeureFin().getHeures())
                {
                    activiteAModifier.setHeureFin(new TimeMartien((int)debutHeure.Value));
                    journeeAModifier.ajouterActivite(activiteAModifier);
                }
                else if (activiteAModifier.getHeureDebut().getHeures() == a.getHeureDebut().getHeures()
                            && activiteAModifier.getHeureFin().getHeures() > a.getHeureFin().getHeures())
                {
                    activiteAModifier.setHeureDebut(new TimeMartien((int)finHeure.Value));
                    journeeAModifier.ajouterActivite(activiteAModifier);
                }

                journeeAModifier.ajouterActivite(a);
            }

            cm.miseAJourEdt(journeeAModifier);
            fermerFenetre();
        }
    }
}
