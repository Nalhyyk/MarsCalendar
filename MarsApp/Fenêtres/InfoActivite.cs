﻿using System;
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

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        public InfoActivite(Activite a)
        {
            if (a.getHeureFin().getHeures() == 24 && a.getHeureFin().getMinutes() == 39)
                a.setHeureFin(new TimeMartien(0));

            InitializeComponent();
            activiteSelectionnee = a;

            debutHeure.Value = activiteSelectionnee.getHeureDebut().getHeures();
            finHeure.Value = activiteSelectionnee.getHeureFin().getHeures();

            debutMinute.Value = activiteSelectionnee.getHeureDebut().getMinutes();
            finMinute.Value = activiteSelectionnee.getHeureFin().getMinutes();

            debutHeure.Minimum = debutHeure.Value;
            finHeure.Maximum = (finHeure.Value == 0) ? 24 : finHeure.Value;

            finHeure.Minimum = (finHeure.Value == 0) ? 0 : debutHeure.Value;

            if (finHeure.Value == 0 && finMinute.Value == 0)
            {
                finHeure.Value = 24;
                finMinute.Value = 40;
            }

            debutHeure.Maximum = finHeure.Value;

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
        #endregion

        #region Evènements
        private void ok_Click(object sender, EventArgs e)
        {
            fermerFenetre();
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
