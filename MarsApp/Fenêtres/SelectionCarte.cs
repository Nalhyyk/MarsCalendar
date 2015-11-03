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
    public partial class SelectionCarte : BaseFenetre
    {
        private Lieu lieuAModifier;
        private TextBox textBoxAModifier;

        public SelectionCarte(Lieu lieuAModifier, TextBox textBoxAModifier)
        {
            InitializeComponent();

            this.lieuAModifier = lieuAModifier;
            this.textBoxAModifier = textBoxAModifier;
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            lieuAModifier.setLieu(e);
            textBoxAModifier.Text = lieuAModifier.ToString();
            fermerFenetre();
        }

        private void map_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Location = new Point(e.X + 20, e.Y - 20);
            
            int x = e.X, y = e.Y;
            Lieu.convertirPosition(ref x, ref y);

            label1.Text = x + ";" + y;
        }
    }
}
