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
    /// Interface de progression d'une tâche
    /// </summary>
    public partial class Progression : BaseFenetre
    {
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
        /// <param name="nb">Nombre d'éléments à compter pour arriver à 100%</param>
        public Progression(int nb)
        {
            InitializeComponent();
            this.progressBar1.Maximum = nb;
        }

        /// <summary>
        /// Progression de la tâche
        /// </summary>
        public void incrementer()
        {
            this.progressBar1.PerformStep();
            this.pourcentage.Text = Math.Round(((float)this.progressBar1.Value / (float)this.progressBar1.Maximum) * 100, 0) + "%";
            this.Refresh();
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
