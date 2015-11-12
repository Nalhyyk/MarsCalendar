using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

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

        private int journeeSelectionnee;
        private int heureSelectionnee;

        private List<Astronaute> astronautes;
        private Astronaute astronauteSelectionne;
        private Dictionary<int, Journee> journeesMission;

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
            astronautes = new List<Astronaute>();

            initialiserDomaines();

            Astronaute a = new Astronaute("Bilat", "Bob", 43);
            astronauteSelectionne = a;
            astronautes.Add(a);
            astronautes.Add(new Astronaute("Filoutub", "René", 57));
            astronautes.Add(new Astronaute("Pasda", "Madeleine", 64));

            journeesMission = astronauteSelectionne.getJourneesMission();

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

            foreach (Astronaute astro in astronautes)
            {
                astro.creerEdT(numJour);
                astroList.Items.Add(astro);
            }

            journeeActuelle = journeesMission[numJour];

            changerPeriode(periode);
            verificationChangementPeriode();
            mettreAJourHeures();
            miseAJourEdt(journeesMission[journeeSelectionnee]);

            descriptionTexte.Text = journeesMission[journeeSelectionnee].getDescription();
            astroList.SelectedItem = astronauteSelectionne;
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
                
                foreach (Domaine d in domaines)
                    if (d.getNomActivites().Contains(a.getNom()) || d.getNom().Equals(a.getNom()))
                        heures[i].BackColor = Color.FromArgb(d.getCouleur()[0], d.getCouleur()[1], d.getCouleur()[2]);

                if (a.isActiviteExterieure())
                {
                    Bitmap img = (a.isExploration()) ? ((ExplorationExterieure) a).deplacement() : ((ExperienceExterieure) a).deplacement();
                    iconesActivite[i].Image = img;
                    iconesActivite[i].Visible = true;
                }
                else
                    iconesActivite[i].Visible = false;
            }
        }

        /// <summary>
        /// Permet d'initialiser les domaines
        /// </summary>
        public void initialiserDomaines()
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load("Donnees/Domaines.xml");
            }
            catch
            {
                string message = "Aucun fichier de sauvegarde n'a été trouvé.";
                MessageBox.Show(message);
                creationDomainesAutomatique();
                return;
            }

            XmlNodeList nodeListDomaines = xmlDoc.GetElementsByTagName("Domaine");

            foreach (XmlNode node in nodeListDomaines)
            {
                String nom = node.SelectSingleNode("Nom").InnerText;
                String r = node.SelectSingleNode("R").InnerText;
                String g = node.SelectSingleNode("G").InnerText;
                String b = node.SelectSingleNode("B").InnerText;
                int[] couleur;

                try
                {
                    couleur = new int[] { int.Parse(r), int.Parse(g), int.Parse(b) };
                }
                catch
                {
                    couleur = new int[] { 0, 0, 0 };
                }

                Domaine d = new Domaine(nom, couleur);

                CalendrierMission.domaines.Add(d);

                XmlNodeList nodeListTA = node.SelectNodes("NomTA");

                foreach (XmlNode nnode in nodeListTA)
                {
                    d.ajouterActivite(new TypeActivite(nnode.SelectSingleNode("NomTA").InnerText));
                }
            }
        }

        public void creationDomainesAutomatique()
        {
            Domaine d = new Domaine("Vie", new int[] { 255, 204, 204 });
            d.ajouterActivite(new TypeActivite("Manger"));
            d.ajouterActivite(new TypeActivite("Dormir"));
            d.ajouterActivite(new TypeActivite("Entraînement"));
            d.ajouterActivite(new TypeActivite("Privé"));
            d.ajouterActivite(new TypeActivite("Contrôle de santé"));
            d.ajouterActivite(new TypeActivite("Acte médical"));
            domaines.Add(d);

            d = new Domaine("Science", new int[] { 204, 230, 255 });
            d.ajouterActivite(new TypeActivite("Exploration"));
            d.ajouterActivite(new TypeActivite("Briefing"));
            d.ajouterActivite(new TypeActivite("Débriefing"));
            d.ajouterActivite(new TypeActivite("Expérience en intérieur"));
            d.ajouterActivite(new TypeActivite("Expérience en extérieur"));
            domaines.Add(d);

            d = new Domaine("Maintenance", new int[] { 217, 204, 255 });
            d.ajouterActivite(new TypeActivite("Nettoyage"));
            d.ajouterActivite(new TypeActivite("LSS système d'air"));
            d.ajouterActivite(new TypeActivite("LSS système d'eau"));
            d.ajouterActivite(new TypeActivite("LSS système de nourriture"));
            d.ajouterActivite(new TypeActivite("Systèmes électriques"));
            d.ajouterActivite(new TypeActivite("Combinaison spatiale"));
            d.ajouterActivite(new TypeActivite("Systèmes électriques"));
            d.ajouterActivite(new TypeActivite("Autre"));
            domaines.Add(d);

            d = new Domaine("Communication", new int[] { 204, 255, 204 });
            d.ajouterActivite(new TypeActivite("Envoyer message"));
            d.ajouterActivite(new TypeActivite("Recevoir message"));
            domaines.Add(d);

            d = new Domaine("Réparation", new int[] { 240, 240, 192 });
            d.ajouterActivite(new TypeActivite("LSS"));
            d.ajouterActivite(new TypeActivite("Systèmes électriques"));
            d.ajouterActivite(new TypeActivite("Systèmes de communication"));
            d.ajouterActivite(new TypeActivite("Systèmes de propulsion"));
            d.ajouterActivite(new TypeActivite("Habitat"));
            d.ajouterActivite(new TypeActivite("Combinaison spatiale"));
            d.ajouterActivite(new TypeActivite("Véhicule"));
            domaines.Add(d);

            d = new Domaine("Secours", new int[] { 255, 204, 255 });
            domaines.Add(d);
        }

        #region Génération XML
        public void genererDocXML()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlNode donnees = xmlDoc.CreateElement("Donnees");
            xmlDoc.AppendChild(donnees);

            XmlNode debutMission = xmlDoc.CreateElement("DebutMission");
            donnees.AppendChild(debutMission);

            XmlNode jour = xmlDoc.CreateElement("Jour");
            XmlNode mois = xmlDoc.CreateElement("Mois");
            XmlNode annee = xmlDoc.CreateElement("Annee");
            XmlNode heures = xmlDoc.CreateElement("Heures");
            XmlNode minutes = xmlDoc.CreateElement("Minutes");
            XmlNode secondes = xmlDoc.CreateElement("Secondes");

            debutMission.AppendChild(jour);
            debutMission.AppendChild(mois);
            debutMission.AppendChild(annee);
            debutMission.AppendChild(heures);
            debutMission.AppendChild(minutes);
            debutMission.AppendChild(secondes);

            jour.InnerText = this.debutMission.Day.ToString();
            mois.InnerText = this.debutMission.Month.ToString();
            annee.InnerText = this.debutMission.Year.ToString();
            heures.InnerText = this.debutMission.Hour.ToString();
            minutes.InnerText = this.debutMission.Minute.ToString();
            secondes.InnerText = this.debutMission.Second.ToString();

            XmlNode astronautes = xmlDoc.CreateElement("Astronautes");
            donnees.AppendChild(astronautes);
            
            foreach (Astronaute a in this.astronautes)
            {
                XmlNode astronaute = xmlDoc.CreateElement("Astronaute");
                astronautes.AppendChild(astronaute);
                a.genererXML(xmlDoc, astronaute);
            }

            if (!System.IO.Directory.Exists("Donnees"))
                System.IO.Directory.CreateDirectory("Donnees");

            xmlDoc.Save("Donnees/Mars-o-Matic.xml");

            XmlDocument xmlDocDom = new XmlDocument();
            XmlNode domaines = xmlDocDom.CreateElement("Domaines");
            xmlDocDom.AppendChild(domaines);

            foreach (Domaine d in CalendrierMission.domaines)
            {
                XmlNode domaine = xmlDocDom.CreateElement("Domaine");
                domaines.AppendChild(domaine);

                XmlNode nomD = xmlDocDom.CreateElement("NomDom");
                domaine.AppendChild(nomD);
                nomD.InnerText = d.getNom();

                XmlNode couleur = xmlDocDom.CreateElement("Couleur");
                domaine.AppendChild(couleur);

                XmlNode r = xmlDocDom.CreateElement("R");
                couleur.AppendChild(r);
                r.InnerText = d.getCouleur()[0].ToString();

                XmlNode g = xmlDocDom.CreateElement("G");
                couleur.AppendChild(g);
                g.InnerText = d.getCouleur()[1].ToString();

                XmlNode b = xmlDocDom.CreateElement("B");
                couleur.AppendChild(b);
                b.InnerText = d.getCouleur()[2].ToString();

                XmlNode typeActivite = xmlDocDom.CreateElement("TypeActivite");
                domaine.AppendChild(typeActivite);

                foreach (TypeActivite ta in d.getActivites())
                {
                    XmlNode nomType = xmlDocDom.CreateElement("NomTA");
                    typeActivite.AppendChild(nomType);
                    nomType.InnerText = ta.getNom();
                }

                xmlDocDom.Save("Donnees/Domaines.xml");
            }
        }
        #endregion

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
            genererDocXML();
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

        private void astroList_SelectedIndexChanged(object sender, EventArgs e)
        {
            astronauteSelectionne = (Astronaute) astroList.SelectedItems[0];
            journeesMission = astronauteSelectionne.getJourneesMission();
            miseAJourEdt(journeesMission[journeeSelectionnee]);
            changerPeriode(periode);
            descriptionTexte.Text = journeesMission[journeeSelectionnee].getDescription();
            this.Refresh();
        }

        private void informationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journee journee = journeesMission[journeeSelectionnee];
            Activite activiteAAfficher = journee.trouverActivite(heureSelectionnee);
            InfoActivite ia = new InfoActivite(activiteAAfficher);
            ia.Show();
        }
#endregion
    }
}
