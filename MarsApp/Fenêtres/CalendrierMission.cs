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
        private Dictionary<int, PictureBox> iconesActivite;
        private Dictionary<int, Label> numeros;
        private Dictionary<int, Label> heures;

        private Dictionary<int, Journee> journeesMission;
        private int journeeSelectionnee;
        private int heureSelectionnee;

        private Journee journeeActuelle;
        private DateTime debutMission;

        public static List<Domaine> domaines;

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public CalendrierMission(DateTime dt)
        {
            InitializeComponent();

            debutMission = dt;

            periode = 1;
            journeeSelectionnee = 1;

            panels = new Dictionary<int, Panel>();
            icones = new Dictionary<int, PictureBox>();
            iconesActivite = new Dictionary<int, PictureBox>();
            numeros = new Dictionary<int, Label>();
            heures = new Dictionary<int, Label>();
            domaines = new List<Domaine>();
            journeesMission = new Dictionary<int, Journee>();

            initialiserDomaines();

            // Création des jours de mission
            for (int i = 1; i < 501; ++i)
                journeesMission[i] = new Journee(i);

            // Stockage des éléments de l'interface [journées]
            for (int i = 1; i < 51; ++i)
            {
                Control[] ctrl = this.Controls.Find("jour" + i, true);
                panels[i] = (Panel)ctrl[0];

                ctrl = this.Controls.Find("num" + i, true);
                numeros[i] = (Label)ctrl[0];

                ctrl = this.Controls.Find("astro" + i, true);
                icones[i] = (PictureBox)ctrl[0];
            }

            // Stockage des éléments de l'interface [activités journée]
            for (int i = 0; i < 24; ++i)
            {
                Control[] ctrl = this.Controls.Find("actH" + i, true);
                heures[i] = (Label)ctrl[0];

                ctrl = this.Controls.Find("h" + i + "img", true);
                iconesActivite[i] = (PictureBox)ctrl[0];
                iconesActivite[i].Visible = false;
            }       

            TimeMartien nb = TimeMartien.calculerJours(debutMission);
            int numJour = nb.getJours() + 1;

            journeeActuelle = journeesMission[numJour];

            // Mise à jour des jours : passés | en cours | à venir
            for (int i = 1; i < numJour; ++i)
                journeesMission[i].journeePassee();
            journeeActuelle = journeesMission[numJour];
            journeesMission[numJour].journeeEnCours();

            changerPeriode(periode);
            verificationChangementPeriode();
            mettreAJourHeures();
            miseAJourEdt(journeesMission[journeeSelectionnee]);

            descriptionTexte.Text = journeesMission[journeeSelectionnee].getDescription();
        }
        #endregion

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
        /// Permet de mettre à jour l'emploi du temps
        /// </summary>
        /// <param name="journee">La journée à mettre à jour</param>
        public void miseAJourEdt(Journee journee)
        {
            numJourneeLabel.Text = "Journée " + journeeSelectionnee;

            foreach (Activite a in journee.getActivites())
            {
                lierActiviteEtEdt(a);
            }

            int jourPeriode = journee.getNumero();
            
            while (jourPeriode > 50)
                jourPeriode -= 50;

            if (journee.isJourneeExterieure())
                icones[jourPeriode].Visible = true;
            else
                icones[jourPeriode].Visible = false;

            avancementMission.Value = (int) ((journeeActuelle.getNumero() * 100) / Constantes.NB_JOUR_MISSION);
        }

        /// <summary>
        /// Permet d'associer une activité à un label ou un groupe de labels
        /// </summary>
        /// <param name="a">Une activité</param>
        public void lierActiviteEtEdt(Activite a)
        {
            int debut = a.getHeureDebut().getHeures();
            int fin = a.getHeureFin().getHeures();

            if (fin == 0)
                fin = 24;

            String nom = a.getNom();

            for (int i = debut; i < fin; ++i)
            {
                heures[i].Text = a.getNom();

                if (a.isActiviteExterieure())
                    iconesActivite[i].Visible = true;
                else
                    iconesActivite[i].Visible = false;
            }
        }

        /// <summary>
        /// Permet d'initialiser les domaines
        /// </summary>
        public void initialiserDomaines()
        {
            Domaine d = new Domaine("Vie");
            d.ajouterActivite(new TypeActivite("Manger"));
            d.ajouterActivite(new TypeActivite("Dormir"));
            d.ajouterActivite(new TypeActivite("Entraînement"));
            d.ajouterActivite(new TypeActivite("Privé"));
            d.ajouterActivite(new TypeActivite("Contrôle de santé"));
            d.ajouterActivite(new TypeActivite("Acte médical"));
            domaines.Add(d);

            d = new Domaine("Science");
            d.ajouterActivite(new TypeActivite("Exploration"));
            d.ajouterActivite(new TypeActivite("Briefing"));
            d.ajouterActivite(new TypeActivite("Débriefing"));
            d.ajouterActivite(new TypeActivite("Expérience en intérieur"));
            d.ajouterActivite(new TypeActivite("Expérience en extérieur"));
            domaines.Add(d);

            d = new Domaine("Maintenance");
            d.ajouterActivite(new TypeActivite("Nettoyage"));
            d.ajouterActivite(new TypeActivite("LSS système d'air"));
            d.ajouterActivite(new TypeActivite("LSS système d'eau"));
            d.ajouterActivite(new TypeActivite("LSS système de nourriture"));
            d.ajouterActivite(new TypeActivite("Systèmes électriques"));
            d.ajouterActivite(new TypeActivite("Combinaison spatiale"));
            d.ajouterActivite(new TypeActivite("Systèmes électriques"));
            d.ajouterActivite(new TypeActivite("Autre"));
            domaines.Add(d);

            d = new Domaine("Communication");
            d.ajouterActivite(new TypeActivite("Envoyer message"));
            d.ajouterActivite(new TypeActivite("Recevoir message"));
            domaines.Add(d);

            d = new Domaine("Réparation");
            d.ajouterActivite(new TypeActivite("LSS"));
            d.ajouterActivite(new TypeActivite("Systèmes électriques"));
            d.ajouterActivite(new TypeActivite("Systèmes de communication"));
            d.ajouterActivite(new TypeActivite("Systèmes de propulsion"));
            d.ajouterActivite(new TypeActivite("Habitat"));
            d.ajouterActivite(new TypeActivite("Combinaison spatiale"));
            d.ajouterActivite(new TypeActivite("Véhicule"));
            domaines.Add(d);

            d = new Domaine("Secours");
            domaines.Add(d);
        }

        #region Evènements
        private void Modifier_Click(object sender, EventArgs e)
        {
            Journee journee = journeesMission[journeeSelectionnee];

            if (journee.isModifiable())
            {
                Activite activiteAModifier = journee.trouverActivite(heureSelectionnee);

                ModificationActivite ma = new ModificationActivite(journee, activiteAModifier, this);
                ma.Show();
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
            descriptionTexte.Text = journeesMission[journeeSelectionnee].getDescription();
        }

        private void heure_MouseClick(object sender, MouseEventArgs e)
        {
            heureSelectionnee = int.Parse(((Label)sender).Tag.ToString());
            clicDroitActivite.Show(Cursor.Position);
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            Journee journee = journeesMission[journeeSelectionnee];

            if (journee.isModifiable())
            {
                Activite activiteAModifier = journee.trouverActivite(heureSelectionnee);
                Activite a = new Activite(new TypeActivite("Privé"), "", new TimeMartien(activiteAModifier.getHeureDebut().getHeures()), new TimeMartien(activiteAModifier.getHeureFin().getHeures()), new Lieu(0, 0));

                journee.supprimerActivite(activiteAModifier);
                journee.ajouterActivite(a);

                miseAJourEdt(journee);
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
        /// Permet de mettre à jour les heures terrestre et martienne
        /// </summary>
        public void mettreAJourHeures()
        {
            terre.Text = DateTime.Now.ToLocalTime().ToString();
            mars.Text = TimeMartien.calculerJours(debutMission).ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            mettreAJourHeures();
        }

        private void CalendrierMission_FormClosed(object sender, FormClosedEventArgs e)
        {
            fermerApplication();
        }

        private void timerJour_Tick(object sender, EventArgs e)
        {
            TimeMartien nb = TimeMartien.calculerJours(debutMission);
            int numJour = nb.getJours() + 1;

            journeeActuelle = journeesMission[numJour];

            for (int i = 1; i < numJour; ++i)
                journeesMission[i].journeePassee();
            journeeActuelle = journeesMission[numJour];
            journeesMission[numJour].journeeEnCours();

            changerPeriode(periode);
            verificationChangementPeriode();
            mettreAJourHeures();
            miseAJourEdt(journeesMission[journeeSelectionnee]);
        }

        private void saveDesc_Click(object sender, EventArgs e)
        {
            journeesMission[journeeSelectionnee].setRapport(descriptionTexte.Text);
        }

        private void map_Click(object sender, EventArgs e)
        {
            GestionCarte gc = new GestionCarte(journeesMission);
            gc.Show();
        }
#endregion
    }
}
