﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarsApp
{
    public partial class CalendrierMission : BaseFenetre
    {
        private int periode;
        private Dictionary<int, Panel> panels;
        private Dictionary<int, PictureBox> icones;
        private Dictionary<int, Label> numeros;

        private Dictionary<int, Journee> journeesMission;

        public CalendrierMission()
        {
            periode = 1;
            InitializeComponent();

            panels = new Dictionary<int, Panel>();
            icones = new Dictionary<int, PictureBox>();
            numeros = new Dictionary<int, Label>();

            journeesMission = new Dictionary<int, Journee>();

            for (int i = 1; i < 501; ++i)
                journeesMission[i] = new Journee(i);

            for (int i = 1; i < 51; ++i)
            {
                Control[] ctrl = this.Controls.Find("jour" + i, true);
                panels[i] = (Panel)ctrl[0];

                ctrl = this.Controls.Find("num" + i, true);
                numeros[i] = (Label)ctrl[0];

                ctrl = this.Controls.Find("astro" + i, true);
                icones[i] = (PictureBox)ctrl[0];
            }

            journeesMission[1].journeePassee();
            journeesMission[2].journeeEnCours();
            journeesMission[189].setJourneeExterieure(true);

            changerPeriode(periode);
        }

        public void changerPeriode(int periode)
        {
            if (periode <= 10 && periode >= 1)
                for (int i = 1; i < 51; ++i)
                {
                    numeros[i].Text = (i + 50 * (periode - 1)).ToString();
                    panels[i].BackColor = Color.FromArgb(journeesMission[i + 50 * (periode - 1)].couleurJournee()[0],
                                                        journeesMission[i + 50 * (periode - 1)].couleurJournee()[1],
                                                        journeesMission[i + 50 * (periode - 1)].couleurJournee()[2]);
                    icones[i].Visible = journeesMission[i + 50 * (periode - 1)].isJourneeExterieure();
                }


        }

        private void changerPeriode_Click(object sender, EventArgs e)
        {
            periode += int.Parse(((PictureBox)sender).Tag.ToString());

            if (periode < 1)
                periode = 1;
            else if (periode > 10)
                periode = 10;

            if (periode == 1)
                precedent.Enabled = false;
            else
                precedent.Enabled = true;

            if (periode == 10)
                suivant.Enabled = false;
            else
                suivant.Enabled = true;

            changerPeriode(periode);

            periodeNum.Text = "Période " + periode;
        }
    }
}
