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
    /// Interface affichant les informations d'une activité
    /// </summary>
    public partial class InfoActivite : BaseFenetre
    {
        private Activite activiteSelectionnee;

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        public InfoActivite(Activite a)
        {
            InitializeComponent();
            activiteSelectionnee = a;

            debutHeure.Value = activiteSelectionnee.getHeureDebut().getHeures();
            finHeure.Value = activiteSelectionnee.getHeureFin().getHeures();
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

            lieuTB.Text = activiteSelectionnee.getLieu().ToString();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            fermerFenetre();
        }
    }
}
