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
    /// Interface de sélection d'un point sur la carte
    /// </summary>
    public partial class SelectionCarte : BaseFenetre
    {
        private Lieu lieuAModifier;
        private TextBox textBoxAModifier;
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
        /// <param name="lieuAModifier">Le lieu à modifier lors de la sélection</param>
        /// <param name="textBoxAModifier">Le textBox à modifier lors de la sélection</param>
        public SelectionCarte(Lieu lieuAModifier, TextBox textBoxAModifier)
        {
            InitializeComponent();

            this.lieuAModifier = lieuAModifier;
            this.textBoxAModifier = textBoxAModifier;
        }
        #endregion

        #region Evènements
        /// <summary>
        /// Permet de sauvegarder le point sur lequel on a cliqué
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            lieuAModifier.setLieu(e);
            textBoxAModifier.Text = lieuAModifier.ToString();
            fermerFenetre();
        }

        /// <summary>
        /// Permet d'afficher les coordonnées, près de la souris
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void map_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Location = new Point(e.X + 20, e.Y - 20);

            int x = e.X, y = e.Y;
            Lieu.convertirPosition(ref x, ref y);

            label1.Text = x + ";" + y;
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
