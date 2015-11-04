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
            DateTime dt = new DateTime(picker.Year, picker.Month, picker.Day, (int)heures.Value, (int)minutes.Value, 0);
            
            CalendrierMission cm = new CalendrierMission(dt);
            cm.Show();
            this.cacherFenetre();
        }
        #endregion
    }
}
