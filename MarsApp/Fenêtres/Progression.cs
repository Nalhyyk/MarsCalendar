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
    /// Interface de progression d'une tâche
    /// </summary>
    public partial class Progression : BaseFenetre
    {
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
        #endregion

        /// <summary>
        /// Progression de la tâche
        /// </summary>
        public void incrementer()
        {
            this.progressBar1.Value += 1;
            this.pourcentage.Text = Math.Round(((float) this.progressBar1.Value / (float) this.progressBar1.Maximum) * 100, 0) + "%";
            this.Refresh();
        }
    }
}
