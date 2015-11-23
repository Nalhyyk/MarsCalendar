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
    public partial class ModificationAstronaute : BaseFenetre
    {
        private Astronaute aModifier;
        private List<Astronaute> astroList;
        private ListBox lb;

        public ModificationAstronaute(Astronaute a, ListBox lb, List<Astronaute> astroList)
        {
            InitializeComponent();
            aModifier = a;
            this.astroList = astroList;
            this.lb = lb;

            nom.Text = aModifier.getNom();
            prenom.Text = aModifier.getPrenom();
            age.Value = aModifier.getAge();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            aModifier.setNom(nom.Text);
            aModifier.setPrenom(prenom.Text);
            aModifier.setAge(Convert.ToInt32(age.Value));
            fermerFenetre();
            lb.DataSource = astroList;
            lb.Refresh();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            fermerFenetre();
        }
    }
}
