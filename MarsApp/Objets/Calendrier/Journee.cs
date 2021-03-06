﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MarsApp
{
    /// <summary>
    /// Gestion d'une journée
    /// </summary>
    public class Journee
    {
        private int numero;
        private IEtat etat;
        private List<Activite> listeActivites;
        private String rapport;
        private bool journeeExterieure;

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Journee() : this(0, "", new Futur(), false) {}

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="numero">Numéro de la journée</param>
        public Journee(int numero) : this(numero, "", new Futur(), false) { }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="numero">Le numéro de la journée</param>
        /// <param name="rapport">Le rapport de la journée</param>
        /// <param name="etat">Etat de la journée</param>
        /// <param name="journeeExterieure">Journée en extérieur ?</param>
        public Journee(int numero, String rapport, IEtat etat, bool journeeExterieure)
        {
            this.numero = numero;
            this.rapport = rapport;
            this.etat = etat;
            this.journeeExterieure = journeeExterieure;
            listeActivites = new List<Activite>();
            ajouterActivite(new Activite(new TypeActivite("Dormir"), "", new TimeMartien(0), new TimeMartien(7), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Manger"), "", new TimeMartien(7), new TimeMartien(8), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Privé"), "", new TimeMartien(8), new TimeMartien(12), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Manger"), "", new TimeMartien(12), new TimeMartien(14), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Privé"), "", new TimeMartien(14), new TimeMartien(19), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Manger"), "", new TimeMartien(19), new TimeMartien(20), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Dormir"), "", new TimeMartien(20), new TimeMartien(24, 40), new Lieu(0, 0)));
        }
        #endregion

        /// <summary>
        /// Ajouter une Activite
        /// </summary>
        /// <param name="a">Une Activite</param>
        public void ajouterActivite(Activite a)
        {
            listeActivites.Add(a);

            if (a.isActiviteExterieure())
                journeeExterieure = true;
        }

        /// <summary>
        /// Supprimer une Activite
        /// </summary>
        /// <param name="a">Une Activite</param>
        public void supprimerActivite(Activite d)
        {
            // Le Remove n'a pas été utilisé à cause d'un bug inconnu
            // qui supprime la mauvaise Activite dans un seul cas précis...
            listeActivites.Remove(d);
            journeeExterieure = mettreAJourJourneeExterieure();
        }

        /// <summary>
        /// Permet de savoir si une activité de la journée se passe en extérieur
        /// </summary>
        /// <returns>Vrai si une activité de la journée se passe en extérieur, faux sinon</returns>
        public bool mettreAJourJourneeExterieure()
        {
            foreach (Activite a in listeActivites)
                if (a.isActiviteExterieure())
                    return true;
            return false;
        }

        /// <summary>
        /// Permet de connaître la couleur de la journée
        /// </summary>
        /// <returns></returns>
        public int[] couleurJournee()
        {
            return etat.couleur();
        }

        /// <summary>
        /// Définit la journée comme étant passée
        /// </summary>
        public void journeePassee()
        {
            etat = new Passe();
        }

        /// <summary>
        /// Définit la journée comme étant en cours
        /// </summary>
        public void journeeEnCours()
        {
            etat = new EnCours();
        }

        /// <summary>
        /// Définit la journée comme étant à venir
        /// </summary>
        public void journeeAVenir()
        {
            etat = new Futur();
        }

        /// <summary>
        /// Permet de trouver une activité dans la journée en fonction d'une heure de début
        /// </summary>
        /// <param name="heure">Une heure</param>
        /// <returns>L'activité se passant à l'heure donnée</returns>
        public Activite trouverActivite(TimeMartien tm, bool debut)
        {
            if (tm != null)
            {
                if (!debut && tm.getHeures() == 0 && tm.getMinutes() == 0 && tm.getSecondes() == 0)
                    tm = new TimeMartien(0, 24, 39, 58);

                foreach (Activite a in listeActivites)
                {
                    if (a.getHeureFin().getHeures() == 0 && a.getHeureFin().getMinutes() == 0 && a.getHeureFin().getSecondes() == 0)
                        a.setHeureFin(new TimeMartien(0, 24, 39, 59));

                    if (a.getHeureDebut() <= tm && a.getHeureFin() > tm)
                    {
                        if (a.getHeureFin().getHeures() == 24 && a.getHeureFin().getMinutes() == 39 && a.getHeureFin().getSecondes() == 59)
                            a.setHeureFin(new TimeMartien(0, 24, 40, 00));
                        return a;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Permet de trouver des activités dans la journée en fonction d'une heure de début
        /// </summary>
        /// <param name="heure">Une heure</param>
        /// <returns>Les activités se passant dans l'heure donnée</returns>
        public List<Activite> trouverActivites(int heureD)
        {
            int heureF = heureD + 1;
            if (heureF > 24)
                heureF -= 25;

            List<Activite> acts = new List<Activite>();

            foreach (Activite a in listeActivites)
            {
                if (TimeMartien.sePasseDansPeriode(a.getHeureDebut(), a.getHeureFin(), new TimeMartien(heureD), new TimeMartien(heureF)))
                    acts.Add(a);
            }

            return acts;
        }

        #region Génération XML
        /// <summary>
        /// Permet de générer la partie XML de l'Activite
        /// </summary>
        /// <param name="xmlDoc">XmlDocument global</param>
        /// <param name="xmlDocActs">XmlDocument pour les activités de base</param>
        /// <param name="journee">Le noeud de la journée</param>
        /// <param name="acts">Le noeud de l'activité (base)</param>
        /// <param name="progression">L'interface de progression</param>
        public void genererXML(XmlDocument xmlDoc, XmlDocument xmlDocActs, XmlNode journee, XmlNode acts, Progression progression)
        {
            XmlNode num = xmlDoc.CreateElement("Numero");
            num.InnerText = this.numero.ToString();
            journee.AppendChild(num);

            XmlNode etat = xmlDoc.CreateElement("Etat");
            etat.InnerText = this.etat.etat();
            journee.AppendChild(etat);

            XmlNode rapport = xmlDoc.CreateElement("Rapport");
            rapport.InnerText = this.rapport;
            journee.AppendChild(rapport);

            XmlNode activites = xmlDoc.CreateElement("Activites");
            journee.AppendChild(activites);

            foreach (Activite a in listeActivites)
            {
                XmlNode activite = xmlDoc.CreateElement("Activite");
                activites.AppendChild(activite);

                a.genererXML(xmlDoc, xmlDocActs, activite, acts, listeActivites, progression);
                progression.incrementer();
            }
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Modifie le rapport de la journée. Il doit faire 1000 caractères maximum
        /// </summary>
        /// <param name="rapport">Rapport de la journée</param>
        /// <returns>false si le rapport fait plus de 1000 caractères, true sinon</returns>
        public bool setRapport(String rapport)
        {
            if (rapport.Length <= Constantes.LIMITE_RAPPORT_JOURNEE)
                this.rapport = rapport;
            else
                return false;

            return true;
        }

        /// <summary>
        /// Permet de savoir si la journée se passe en extérieur
        /// </summary>
        /// <returns>Vrai si la journée se passe en extérieur, faux sinon</returns>
        public bool isJourneeExterieure()
        {
            return journeeExterieure;
        }

        /// <summary>
        /// Permet de savoir si la journée est modifiable
        /// </summary>
        /// <returns>Vrai si la journée est modifiable, faux sinon</returns>
        public bool isModifiable()
        {
            return etat.modifiable();
        }

        /// <summary>
        /// Permet de redéfinir si la journée se passe en extérieur
        /// </summary>
        /// <param name="journeeExterieure">Un booléen</param>
        public void setJourneeExterieure(bool journeeExterieure)
        {
            this.journeeExterieure = journeeExterieure;
        }

        /// <summary>
        /// Permet de connaître les différentes activités de la journée
        /// </summary>
        /// <returns>La liste des activités de la journée</returns>
        public List<Activite> getActivites() { return listeActivites; }

        /// <summary>
        /// Permet de connaître le numéro de la journée
        /// </summary>
        /// <returns>Le numéro de la journée</returns>
        public int getNumero() { return numero; }

        /// <summary>
        /// Permet de connaître la description de la journée
        /// </summary>
        /// <returns>La description de la journée</returns>
        public String getDescription() { return rapport; }

        /// <summary>
        /// Redéfini les activités de la journée
        /// </summary>
        /// <param name="activites">Une liste d'activités</param>
        public void setListeActivites(List<Activite> activites) { this.listeActivites = activites; }

        /// <summary>
        /// Permet d'obtenir l'état de l'activité
        /// </summary>
        /// <returns>L'état de l'activité</returns>
        public String getEtat() { return etat.etat(); }

        /// <summary>
        /// Permet de savoir si la journée est en cours
        /// </summary>
        /// <returns>Vrai si la journée est en cours, faux sinon</returns>
        public bool isEnCours() { return etat.etat().Equals(Constantes.ETAT_ENCOURS); }
        #endregion
    }
}
