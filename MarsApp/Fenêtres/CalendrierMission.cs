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
    /// Interface du calendrier
    /// </summary>
    public partial class CalendrierMission : BaseFenetre
    {
        private int periode;
        private Dictionary<int, Panel> panels;
        private Dictionary<int, PictureBox> icones;
        private Dictionary<int, Label> numeros;
        private Dictionary<int, Label> heures;

        public static Dictionary<int, Journee> journeesMission;
        public static int journeeSelectionnee;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public CalendrierMission()
        {
            InitializeComponent();

            periode = 1;
            journeeSelectionnee = 1;

            panels = new Dictionary<int, Panel>();
            icones = new Dictionary<int, PictureBox>();
            numeros = new Dictionary<int, Label>();
            heures = new Dictionary<int, Label>();

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

            for (int i = 0; i < 25; ++i)
            {
                Control[] ctrl = this.Controls.Find("actH" + i, true);
                heures[i] = (Label)ctrl[0];
            }

            journeesMission[1].journeePassee();
            journeesMission[2].journeePassee();
            journeesMission[3].journeePassee();
            journeesMission[4].journeePassee();
            journeesMission[5].journeePassee();
            journeesMission[6].journeePassee();
            journeesMission[7].journeePassee();
            journeesMission[8].journeeEnCours();

            journeesMission[10].setJourneeExterieure(true);
            

            changerPeriode(periode);
            verificationChangementPeriode();

            miseAJourEdt(journeesMission[journeeSelectionnee]);
        }

        /// <summary>
        /// Permet de changer de période
        /// </summary>
        /// <param name="periode">La période (1 à 10)</param>
        public void changerPeriode(int periode)
        {
            if (periode <= 10 && periode >= 1)
                for (int i = 1; i < 51; ++i)
                {
                    // On met le numéro du jour dans tous les objets situés sur une case
                    numeros[i].Text = (i + 50 * (periode - 1)).ToString();
                    numeros[i].Tag = (i + 50 * (periode - 1)).ToString();
                    icones[i].Tag = (i + 50 * (periode - 1)).ToString();
                    panels[i].Tag = (i + 50 * (periode - 1)).ToString();

                    // Changement du background en fonction de l'état de la journée
                    panels[i].BackColor = Color.FromArgb(journeesMission[i + 50 * (periode - 1)].couleurJournee()[0],
                                                        journeesMission[i + 50 * (periode - 1)].couleurJournee()[1],
                                                        journeesMission[i + 50 * (periode - 1)].couleurJournee()[2]);

                    // Astronaute visible pour les jours en extérieur
                    icones[i].Visible = journeesMission[i + 50 * (periode - 1)].isJourneeExterieure();
                }


        }

        /// <summary>
        /// Permet de passer à la période précédente/suivante
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void changerPeriode_Click(object sender, EventArgs e)
        {
            periode += int.Parse(((PictureBox)sender).Tag.ToString());

            if (periode < 1)
                periode = 1;
            else if (periode > 10)
                periode = 10;

            verificationChangementPeriode();

            changerPeriode(periode);

            periodeNum.Text = "Période " + periode;
        }

        /// <summary>
        /// Active/désactive les boutons de changement de période en fonction des butées
        /// </summary>
        public void verificationChangementPeriode()
        {
            if (periode == 1)
            {
                precedent.Enabled = false;
                precedent.Visible = false;
            }
            else
            {
                precedent.Enabled = true;
                precedent.Visible = true;
            }

            if (periode == 10)
            {
                suivant.Enabled = false;
                suivant.Visible = false;
            }
            else
            {
                suivant.Enabled = true;
                suivant.Visible = true;
            }
        }

        /// <summary>
        /// Actions lors du clic sur un jour
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void jour_click(object sender, EventArgs e)
        {
            String numJournee = "";

            if (sender as Label != null)
                numJournee = ((Label)sender).Tag.ToString();
            else if (sender as PictureBox != null)
                numJournee = ((PictureBox)sender).Tag.ToString();
            else if (sender as Panel != null)
                numJournee = ((Panel)sender).Tag.ToString();

            journeeSelectionnee = int.Parse(numJournee);
            miseAJourEdt(journeesMission[journeeSelectionnee]);
        }

        public void miseAJourEdt(Journee journee)
        {
            numJourneeLabel.Text = "Journée " + journeeSelectionnee;

            foreach (Activite a in journee.getActivites())
            {
                lierActiviteEtEdt(a);
            }
        }

        public void lierActiviteEtEdt(Activite a)
        {
            int debut = a.getHeureDebut().getHeures();
            int fin = a.getHeureFin().getHeures();

            if (fin == 0)
                fin = 24;

            String nom = a.getNom();

            for (int i = debut; i <= fin; ++i)
            {
                heures[i].Text = a.getNom();
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {

        }
    }
}
