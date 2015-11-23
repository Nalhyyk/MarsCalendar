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
    public partial class NouveauAstronaute : BaseFenetre
    {
        private List<Astronaute> astronautes;
        private ListBox astroList;
        private int numJour;

        public NouveauAstronaute(List<Astronaute> astronautes, ListBox astroList, int numJour)
        {
            InitializeComponent();

            this.astronautes = astronautes;
            this.astroList = astroList;
            this.numJour = numJour;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            fermerFenetre();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            Astronaute a = new Astronaute(nom.Text, prenom.Text, Convert.ToInt32(age.Value));
            a.creerEdT(numJour);
            astronautes.Add(a);
            astroList.Items.Add(a);
            fermerFenetre();
        }
    }
}
