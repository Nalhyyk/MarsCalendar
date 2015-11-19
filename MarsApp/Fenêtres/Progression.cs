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
    public partial class Progression : BaseFenetre
    {
        public Progression(int nb)
        {
            InitializeComponent();
            this.progressBar1.Maximum = nb;
        }

        public void incrementer()
        {
            this.progressBar1.Value += 1;
            this.pourcentage.Text = Math.Round(((float) this.progressBar1.Value / (float) this.progressBar1.Maximum) * 100, 0) + "%";
            this.Refresh();
        }
    }
}
