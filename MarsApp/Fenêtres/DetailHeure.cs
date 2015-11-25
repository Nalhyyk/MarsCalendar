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
    public partial class DetailHeure : BaseFenetre
    {
        private Dictionary<int, Label> horaires;
        private Dictionary<int, Label> heures;
        private Dictionary<int, PictureBox> iconesActivite;
        private Journee journee;
        private CalendrierMission cm;
        private int heureSelectionnee;
        private int minuteSelectionnee;
        List<Activite> activites;

        public DetailHeure(int heureSelectionnee, List<Activite> activites, Journee journee, CalendrierMission cm)
        {
            InitializeComponent();

            this.heureSelectionnee = heureSelectionnee;
            this.activites = activites;

            horaires = new Dictionary<int, Label>();
            heures = new Dictionary<int, Label>();
            iconesActivite = new Dictionary<int, PictureBox>();
            this.journee = journee;
            this.cm = cm;

            for (int i = 0; i <= 60; i += 10)
            {
                Control[] ctrl;

                if (i <= 50)
                {
                    ctrl = this.Controls.Find("actM" + i, true);
                    horaires[i] = (Label)ctrl[0];

                    ctrl = this.Controls.Find("h" + i + "img", true);
                    iconesActivite[i] = (PictureBox)ctrl[0];
                }

                ctrl = this.Controls.Find("label" + i, true);
                heures[i] = (Label)ctrl[0];
            }

            foreach (Activite a in activites)
            {
                int debut = a.getHeureDebut().getMinutes();
                int fin = a.getHeureFin().getMinutes();

                int hDebut = a.getHeureDebut().getHeures();
                int hFin = a.getHeureFin().getHeures();

                String nom = a.getNom();

                if (hDebut < heureSelectionnee)
                    debut = 0;
                if (hFin > heureSelectionnee)
                    fin = 60;

                if (fin == 0)
                    fin = 60;

                heures[60].Text = (heureSelectionnee + 1) + "h00";

                for (int i = debut; i < fin; i += 10)
                {
                    if ((heureSelectionnee + "h" + i + ((i < 10) ? "0" : "")).Equals("24h40"))
                        heures[i].Text = "0h00";

                    horaires[i].Text = a.getNom();
                    heures[i].Text = heureSelectionnee + "h" + i + ((i < 10) ? "0" : "");

                    int h = int.Parse(heures[i].Text.Split('h')[0]);
                    int m = int.Parse(heures[i].Text.Split('h')[1]);

                    if (h == 24 && m > 40)
                    {
                        heures[i].Visible = false;
                        horaires[i - 10].Visible = false;
                        this.Size = new Size(379, 158);
                    }

                    foreach (Domaine d in CalendrierMission.domaines)
                        if (d.getNomActivites().Contains(a.getNom()) || d.getNom().Equals(a.getNom()))
                            horaires[i].BackColor = Color.FromArgb(d.getCouleur()[0], d.getCouleur()[1], d.getCouleur()[2]);

                    if (a.isActiviteExterieure())
                    {
                        Bitmap img = (a.isExploration()) ? ((ExplorationExterieure)a).deplacement() : ((ExperienceExterieure)a).deplacement();
                        iconesActivite[i].Image = img;
                        iconesActivite[i].Visible = true;
                    }
                    else
                        iconesActivite[i].Visible = false;
                }
            }
        }

        private void heure_click(object sender, EventArgs e)
        {
            minuteSelectionnee = int.Parse(((Label)sender).Tag.ToString());
            clicDroitActivite.Show(Cursor.Position);
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            ModificationActivite ma = new ModificationActivite(journee, journee.trouverActivite(new TimeMartien(0, heureSelectionnee, minuteSelectionnee, 0)), cm, this);
            ma.Show();
        }

        private void informationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoActivite ia = new InfoActivite(journee.trouverActivite(new TimeMartien(0, heureSelectionnee, minuteSelectionnee, 0)));
            ia.Show();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (journee.isModifiable())
            {
                Activite activiteAModifier = journee.trouverActivite(new TimeMartien(0, heureSelectionnee, minuteSelectionnee, 0));
                Activite a = new Activite(new TypeActivite("Privé"), "", new TimeMartien(activiteAModifier.getHeureDebut().getHeures()), new TimeMartien(activiteAModifier.getHeureFin().getHeures()), new Lieu(0, 0));

                journee.supprimerActivite(activiteAModifier);
                journee.ajouterActivite(a);

                cm.Refresh();
            }
        }
    }
}
