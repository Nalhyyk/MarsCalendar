using System;
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
    /// Interface permettant d'ajouter de nouveaux domaines/types d'activité
    /// </summary>
    public partial class AjouterTA : BaseFenetre
    {
        private ModificationActivite ma;
        private int[] couleurTA;
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
        /// <param name="ma">L'interface ModificationActivite à mettre à jour</param>
        public AjouterTA(ModificationActivite ma)
        {
            InitializeComponent();

            this.ma = ma;
            listBoxDoms.DataSource = CalendrierMission.domaines;
        }
        #endregion

        #region Evènements
        /// <summary>
        /// Permet d'activer/désactiver des contrôles en fonction des radios checkés
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void type_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoms.Enabled = !domaineRadio.Checked;
            couleur.Enabled = domaineRadio.Checked;
        }

        /// <summary>
        /// Permet de créer le domaine/type d'activité
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void ok_Click(object sender, EventArgs e)
        {
            String nom = nomTA.Text;

            if (!nom.Equals(""))
            {
                if (domaineRadio.Checked)
                    CalendrierMission.domaines.Add(new Domaine(nom, couleurTA));
                else
                    CalendrierMission.domaines.Find(elem => elem.getNom().Equals(listBoxDoms.SelectedItem.ToString())).ajouterActivite(new TypeActivite(nom));

                ma.remplirTreeView();

                fermerFenetre();
            }
        }

        /// <summary>
        /// Permet de choisir la couleur du domaine
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void couleur_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                couleurTA = new int[] { colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B };
                couleur.BackColor = colorDialog.Color;
            }
        }

        /// <summary>
        /// Permet d'annuler l'ajout
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void annuler_Click(object sender, EventArgs e)
        {
            fermerFenetre();
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
