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
    /// <summary>
    /// Interface affichant les détails d'une heure, avec une précision de 10 minutes
    /// </summary>
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

        #region Constructeurs
        /// <summary>
        /// COnstructeur paramétré
        /// </summary>
        /// <param name="heureSelectionnee">Une heure</param>
        /// <param name="activites">La liste des activités de la journée</param>
        /// <param name="journee">La journée</param>
        /// <param name="cm">Le CalendrierMission source</param>
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

                if (fin == 0 && heureSelectionnee != 24)
                    fin = 60;
                else if (fin == 0 && heureSelectionnee == 24)
                    fin = 40;

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

                if (heureSelectionnee == 24)
                {
                    for (int i = 40; i < 60; i += 10)
                    {
                        heures[i + 10].Visible = false;
                        iconesActivite[i].Visible = false;
                        horaires[i].Visible = false;
                    }

                    if (fin < 60)
                    {
                        label40.Text = "0h00";
                        label60.Visible = false;
                        this.Size = new Size(379, 158);
                    }
                }
            }
        }
        #endregion

        #region Evènements
        /// <summary>
        /// Permet d'afficher le ContextMenuStrip
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void heure_click(object sender, EventArgs e)
        {
            minuteSelectionnee = int.Parse(((Label)sender).Tag.ToString());
            Activite a = journee.trouverActivite(new TimeMartien(0, heureSelectionnee, minuteSelectionnee, 0), ((heureSelectionnee == 0 && minuteSelectionnee == 0) ? true : false));
            
            if (!a.isModifiable())
            {
                ToolStripItem tsmiModif = clicDroitActivite.Items.Find("Modifier", true)[0];
                ToolStripItem tsmiSuppr = clicDroitActivite.Items.Find("Supprimer", true)[0];
                tsmiModif.Enabled = false;
                tsmiSuppr.Enabled = false;
            }

            clicDroitActivite.Show(Cursor.Position);
        }

        /// <summary>
        /// Permet de modifier l'activité sélectionnée
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void Modifier_Click(object sender, EventArgs e)
        {
            Activite a = journee.trouverActivite(new TimeMartien(0, heureSelectionnee, minuteSelectionnee, 0), ((heureSelectionnee == 0 && minuteSelectionnee == 0) ? true : false));

            if (a.isModifiable())
            {
                ModificationActivite ma = new ModificationActivite(journee, a, cm, this);
                ma.Show();
            }
        }

        /// <summary>
        /// Permet d'obtenir les informations d'une activité
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void informationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoActivite ia = new InfoActivite(journee.trouverActivite(new TimeMartien(0, heureSelectionnee, minuteSelectionnee, 0), ((heureSelectionnee == 0 && minuteSelectionnee == 0) ? true : false)));
            ia.Show();
        }

        /// <summary>
        /// Permet de supprimer une activité
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void Supprimer_Click(object sender, EventArgs e)
        {
            Activite act = journee.trouverActivite(new TimeMartien(0, heureSelectionnee, minuteSelectionnee, 0), ((heureSelectionnee == 0 && minuteSelectionnee == 0) ? true : false));

            if (act.isModifiable())
            {
                Activite activiteAModifier = act;
                Activite a = new Activite(new TypeActivite("Privé"), "", new TimeMartien(0, activiteAModifier.getHeureDebut().getHeures(), activiteAModifier.getHeureDebut().getMinutes(), 0), new TimeMartien(0, activiteAModifier.getHeureFin().getHeures(), activiteAModifier.getHeureFin().getMinutes(), 0), new Lieu(0, 0));

                journee.supprimerActivite(activiteAModifier);
                journee.ajouterActivite(a);

                this.Close();
                cm.ouvrirDernierDetailHeure();
                cm.miseAJourEdt(journee);
            }
        }
    }
        #endregion
}
