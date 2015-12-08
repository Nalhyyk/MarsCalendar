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
    /// Menu principal de l'application
    /// </summary>
    public partial class MenuPrincipal : BaseFenetre
    {
        private String marsOMatic;
        private String activitesRefs;

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
            DateTime dt = new DateTime(picker.Year, picker.Month, picker.Day, (int) heures.Value, (int) minutes.Value, 0);

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
                DateTime picker = dateTimePicker1.Value;
                DateTime dt = new DateTime(picker.Year, picker.Month, picker.Day, (int)heures.Value, (int)minutes.Value, 0);

                if (dt > DateTime.Now)
                {
                    erreurDate.Visible = true;
                    return;
                }

                CalendrierMission cm = new CalendrierMission(dt, true, marsOMatic, activitesRefs);
                cm.Show();
                this.cacherFenetre();
            }
        }
        #endregion
    }
}
