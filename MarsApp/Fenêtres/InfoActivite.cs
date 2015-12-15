﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MarsApp
{
    /// <summary>
    /// Interface affichant les informations d'une activité
    /// </summary>
    public partial class InfoActivite : BaseFenetre
    {
        private Activite activiteSelectionnee;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="a">Activiter à détailler</param>
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
                {
                    explorationRadio.Checked = true;
                    scaphandreRadio.Checked = (((ExplorationExterieure)a).nomTransport().Equals("Scaphandre")) ? true : false;
                    vehiculeRadio.Checked = !scaphandreRadio.Checked;
                }
                else
                {
                    experienceRadio.Checked = true;
                    scaphandreRadio.Checked = (((ExperienceExterieure)a).nomTransport().Equals("Scaphandre")) ? true : false;
                    vehiculeRadio.Checked = !scaphandreRadio.Checked;
                }
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
        /// <summary>
        /// Permet de fermer la fenêtre
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènements</param>
        private void ok_Click(object sender, EventArgs e)
        {
            fermerFenetre();
        }

        /// <summary>
        /// Permet de jouer avec les Max/Min pour l'heure 20h et > 39 minutes
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
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

        /// <summary>
        /// Permet de réduire la fenêtre en cours
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void Reduire_Click(object sender, EventArgs e)
        {
            reduireFenetre();
        }

        /// <summary>
        /// Permet de fermer la fenêtre en cours
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void X_Click(object sender, EventArgs e)
        {
            fermerFenetre();
        }

        /// <summary>
        /// Permet de déplacer la fenêtre par la zone du haut
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        /// <summary>
        /// Permet de modifier la couleur du bouton lors du survol
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void Reduire_MouseHover(object sender, EventArgs e)
        {
            Reduire.BackColor = System.Drawing.Color.FromArgb(0, 148, 241);
        }

        /// <summary>
        /// Permet de revenir à l'état de base après le survol
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void Reduire_MouseLeave(object sender, EventArgs e)
        {
            Reduire.BackColor = System.Drawing.Color.FromArgb(17, 19, 23);
        }

        /// <summary>
        /// Permet de modifier la couleur du bouton lors du survol
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void X_MouseHover(object sender, EventArgs e)
        {
            X.BackColor = System.Drawing.Color.FromArgb(0, 148, 241);
        }

        /// <summary>
        /// Permet de revenir à l'état de base après le survol
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void X_MouseLeave(object sender, EventArgs e)
        {
            X.BackColor = System.Drawing.Color.FromArgb(17, 19, 23);
        }
        #endregion
    }
}
