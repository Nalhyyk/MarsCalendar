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
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime picker = dateTimePicker1.Value;
            DateTime dt = new DateTime(picker.Year, picker.Month, picker.Day, (int) heures.Value, (int) minutes.Value, 0);
            
            CalendrierMission cm = new CalendrierMission(dt, false);
            cm.Show();
            this.cacherFenetre();
        }

        private void marsomaticFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mars-o-Matic (.xml)|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                marsOMatic = ofd.FileName;
                marsomaticFile.Text = marsOMatic;
            }
        }

        private void activitesRefFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ActivitesRefs (.xml)|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                activitesRefs = ofd.FileName;
                activitesRefFile.Text = activitesRefs;
            }
        }

        private void charger_Click(object sender, EventArgs e)
        {
            if (activitesRefs != null && marsOMatic != null)
            {
                DateTime picker = dateTimePicker1.Value;
                DateTime dt = new DateTime(picker.Year, picker.Month, picker.Day, (int)heures.Value, (int)minutes.Value, 0);

                CalendrierMission cm = new CalendrierMission(dt, true, marsOMatic, activitesRefs);
                cm.Show();
                this.cacherFenetre();
            }
        }
        #endregion
    }
}
