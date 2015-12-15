using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;

namespace MarsApp
{
    /// <summary>
    /// Menu principal de l'application
    /// </summary>
    public partial class MenuPrincipal : BaseFenetre
    {
        private String marsOMatic;
        private String activitesRefs;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Evènements
        /// <summary>
        /// Permet de créer les données par défaut, et d'ouvrir le menu "principal" de l'application
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime picker = dateTimePicker1.Value;
            DateTime dt = new DateTime(picker.Year, picker.Month, picker.Day, (int)heures.Value, (int)minutes.Value, 0);

            if (dt > DateTime.Now)
            {
                erreurDate.Visible = true;
                erreurDate.Text = "La date de début de mission ne peut pas être supérieure à la date actuelle";
                return;
            }

            if (TimeMartien.calculerJours(dt).getJours() > 500)
            {
                erreurDate.Visible = true;
                erreurDate.Text = "La durée de la mission dépasse les 500 jours...";
                return;
            }

            CalendrierMission cm = new CalendrierMission(dt, false);
            cm.Show();
            this.cacherFenetre();
        }

        /// <summary>
        /// Permet de charger le premier fichier XML "Mars-o-Matic"
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void marsomaticFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mars-o-Matic (.xml)|Mars-o-Matic*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                marsOMatic = ofd.FileName;
                marsomaticFile.Text = marsOMatic;
            }
        }

        /// <summary>
        /// Permet de charger le deuxième fichier XML "ActivitesRefs"
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void activitesRefFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ActivitesRefs (.xml)|ActivitesRefs*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                activitesRefs = ofd.FileName;
                activitesRefFile.Text = activitesRefs;
            }
        }

        /// <summary>
        /// Permet de créer les données à partir des fichiers XML, et d'ouvrir le menu "principal" de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void charger_Click(object sender, EventArgs e)
        {
            if (activitesRefs != null && marsOMatic != null)
            {
                XmlDocument mars = new XmlDocument();
                mars.Load(marsOMatic);

                int jour = int.Parse(mars.SelectSingleNode("Donnees").SelectSingleNode("DebutMission").SelectSingleNode("Jour").InnerText);
                int mois = int.Parse(mars.SelectSingleNode("Donnees").SelectSingleNode("DebutMission").SelectSingleNode("Mois").InnerText);
                int annee = int.Parse(mars.SelectSingleNode("Donnees").SelectSingleNode("DebutMission").SelectSingleNode("Annee").InnerText);
                int heures = int.Parse(mars.SelectSingleNode("Donnees").SelectSingleNode("DebutMission").SelectSingleNode("Heures").InnerText);
                int minutes = int.Parse(mars.SelectSingleNode("Donnees").SelectSingleNode("DebutMission").SelectSingleNode("Minutes").InnerText);
                int secondes = int.Parse(mars.SelectSingleNode("Donnees").SelectSingleNode("DebutMission").SelectSingleNode("Secondes").InnerText);

                DateTime debutMission = new DateTime(annee, mois, jour, heures, minutes, secondes);

                if (debutMission > DateTime.Now)
                {
                    erreurDate.Text = "La date de début de mission ne peut pas être supérieure à la date actuelle";
                    erreurDate.Visible = true;
                    return;
                }

                CalendrierMission cm = new CalendrierMission(debutMission, true, marsOMatic, activitesRefs);
                cm.Show();
                this.cacherFenetre();
            }
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
        /// Permet de fermer l'application
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void X_Click(object sender, EventArgs e)
        {
            fermerApplication();
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
