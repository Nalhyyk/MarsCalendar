using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MarsApp
{
    /// <summary>
    /// Classe regroupant les informations d'une activité
    /// </summary>
    public class Activite : IEquatable<Activite>
    {
        protected static List<Activite> saveFichier;
        protected static int nbActivite = 0;
        protected int numero;
        protected TypeActivite typeActivite;
        protected String description;
        protected IEtat etat;
        protected TimeMartien heureDebut;
        protected TimeMartien heureFin;
        protected Lieu lieu;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="typeActivite">Type de l'Activite</param>
        public Activite(TypeActivite typeActivite) : this(typeActivite, "", new TimeMartien(), new TimeMartien(), new Lieu(0, 0)) {}

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="typeActivite">Type de l'Activite</param>
        /// <param name="description">Description de l'Activite</param>
        /// <param name="deb">Date de début de l'Activite</param>
        /// <param name="fin">Date de fin de l'Activite</param>
        /// <param name="lieu">Lieu de l'Activite</param>
        public Activite(TypeActivite typeActivite, String description, TimeMartien deb, TimeMartien fin, Lieu lieu)
        {
            this.typeActivite = typeActivite;
            this.description = description;
            etat = new Futur();
            this.heureDebut = deb;
            this.heureFin = fin;
            saveFichier = new List<Activite>();
            this.lieu = lieu;
            numero = ++nbActivite;
        }

        public Activite(Activite a)
        {
            typeActivite = a.typeActivite;
            description = a.description;
            etat = a.etat;
            heureDebut = a.heureDebut;
            heureFin = a.heureFin;
            saveFichier = new List<Activite>();
            lieu = a.lieu;
            numero = ++nbActivite;
        }
        #endregion

        /// <summary>
        /// Affiche l'état de l'activité
        /// </summary>
        public void etatActivite()
        {
            etat.etat();
        }

        /// <summary>
        /// Permet de connaître la couleur de l'activité
        /// </summary>
        /// <returns></returns>
        public int[] couleurActivite()
        {
            return etat.couleur();
        }

        /// <summary>
        /// Définit l'activité comme étant passée
        /// </summary>
        public void activitePassee()
        {
            etat = new Passe();
        }

        /// <summary>
        /// Définit l'activité comme étant en cours
        /// </summary>
        public void activiteEnCours()
        {
            etat = new EnCours();
        }

        /// <summary>
        /// Définit l'activité comme étant à venir
        /// </summary>
        public void activiteAVenir()
        {
            etat = new Futur();
        }

        public bool Equals(Activite other)
        {
            if (other.getNom().Equals(this.getNom()))
                if (other.isActiviteExterieure() == this.isActiviteExterieure())
                    if (other.isExperience() == this.isExperience())
                        if (other.getDescription().Equals(this.description))
                            if (other.heureDebut == this.heureDebut)
                                if (other.heureFin == this.heureFin)
                                    return true;
            return false;
        }

        public int activiteRentreeDansFichier(List<Activite> liste)
        {
            foreach (Activite a in liste)
                if (this.Equals(a))
                    if (saveFichier.Contains(a))
                    {
                        int num = saveFichier.Find(act => act.Equals(this)).numero;
                        return num;
                    }

            return -1;
        }

        #region Génération XML
        public void genererXML(XmlDocument xmlDoc, XmlDocument xmlDocActs, XmlNode activite, XmlNode acts, List<Activite> listeActivites, Progression progression)
        {
            bool actExt = (isExploration() || isExperience());

            /* Général */

            int numRecherche = activiteRentreeDansFichier(listeActivites);

            if (numRecherche == -1)
            {
                XmlNode act = xmlDocActs.CreateElement("Activite");
                acts.AppendChild(act);

                XmlNode numero = xmlDocActs.CreateElement("Numero");
                numero.InnerText = this.numero.ToString();
                act.AppendChild(numero);

                XmlNode exterieure = xmlDocActs.CreateElement("Exterieure");
                exterieure.InnerText = actExt.ToString();
                act.AppendChild(exterieure);

                XmlNode exploration = xmlDocActs.CreateElement("Exploration");
                exploration.InnerText = isExploration().ToString();
                act.AppendChild(exploration);

                XmlNode typeActivite = xmlDocActs.CreateElement("TypeActivite");
                act.AppendChild(typeActivite);
                this.typeActivite.genererXML(xmlDocActs, typeActivite);

                saveFichier.Add(this);
            }

            /* Détail activité */

            XmlNode num = xmlDoc.CreateElement("Numero");
            num.InnerText = (numRecherche == -1) ? this.numero.ToString() : numRecherche.ToString();
            activite.AppendChild(num);

            XmlNode transport = xmlDoc.CreateElement("Transport");

            if (actExt)
                if (isExploration())
                    transport.InnerText = ((ExplorationExterieure) this).nomTransport();
                else
                    transport.InnerText = ((ExperienceExterieure) this).nomTransport();
            else
                transport.InnerText = "";

            activite.AppendChild(transport);

            XmlNode description = xmlDoc.CreateElement("Description");
            activite.AppendChild(description);
            description.InnerText = this.description;

            XmlNode etat = xmlDoc.CreateElement("Etat");
            etat.InnerText = this.etat.etat();
            activite.AppendChild(etat);

            XmlNode heureDebut = xmlDoc.CreateElement("HeureDebut");
            activite.AppendChild(heureDebut);
            this.heureDebut.genererXML(xmlDoc, heureDebut);

            XmlNode heureFin = xmlDoc.CreateElement("HeureFin");
            activite.AppendChild(heureFin);
            this.heureFin.genererXML(xmlDoc, heureFin);

            XmlNode lieu = xmlDoc.CreateElement("XY");
            activite.AppendChild(lieu);
            this.lieu.genererXML(xmlDoc, lieu);
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Modifie la description de l'Activite. Elle doit faire 400 caractères maximum
        /// </summary>
        /// <param name="description">Description de l'Activite</param>
        /// <returns>false si la description fait plus de 400 caractères, true sinon</returns>
        public bool setDescription(String description)
        {
            if (description.Length <= Constantes.LIMITE_DESCRIPTION_ACTIVITE)
                this.description = description;
            else
                return false;

            return true;
        }

        /// <summary>
        /// Permet de savoir si l'activité se déroule en extérieur
        /// </summary>
        /// <returns>Vrai si l'activité est une Experience/ExplorationExterieure, faux sinon</returns>
        public virtual bool isActiviteExterieure()
        {
            return false;
        }

        /// <summary>
        /// Permet de savoir si l'activité est une activité d'exploration
        /// </summary>
        /// <returns>Vrai si l'activité est une exploration, faux sinon</returns>
        public virtual bool isExploration()
        {
            return false;
        }

        /// <summary>
        /// Permet de savoir si l'activité est une activité d'expérience
        /// </summary>
        /// <returns>Vrai si l'activité est une experience, faux sinon</returns>
        public virtual bool isExperience()
        {
            return false;
        }

        /// <summary>
        /// Permet de savoir si l'activité est modifiable
        /// </summary>
        /// <returns>Vrai si elle est modifiable, faux sinon</returns>
        public bool isModifiable()
        {
            return etat.modifiable();
        }

        /// <summary>
        /// Permet d'avoir l'heure de début de l'activité
        /// </summary>
        /// <returns>L'heure de début de l'activité</returns>
        public TimeMartien getHeureDebut() { return heureDebut; }

        /// <summary>
        /// Permet d'avoir l'heure de fin de l'activité
        /// </summary>
        /// <returns>L'heure de fin de l'activité</returns>
        public TimeMartien getHeureFin() { return heureFin; }

        /// <summary>
        /// Permet d'avoir le nom de l'activité
        /// </summary>
        /// <returns>Le nom de l'activité</returns>
        public String getNom() { return typeActivite.getNom(); }

        /// <summary>
        /// Permet de définir l'heure de début de l'activité
        /// </summary>
        /// <param name="tm">Un TimeMartien</param>
        public void setHeureDebut(TimeMartien tm) { this.heureDebut = tm; }

        /// <summary>
        /// Permet de définir l'heure de fin de l'activité
        /// </summary>
        /// <param name="tm">Un TimeMartien</param>
        public void setHeureFin(TimeMartien tm) { this.heureFin = tm; }

        /// <summary>
        /// Permet de connaître la durée de l'activité
        /// </summary>
        /// <returns>La durée de l'activité</returns>
        public TimeMartien getDuree() { return heureFin - heureDebut; }

        /// <summary>
        /// Permet de connaître la description de l'activité
        /// </summary>
        /// <returns>La description de l'activité</returns>
        public String getDescription() { return description; }

        /// <summary>
        /// Permet de connaître le lieu de l'activité
        /// </summary>
        /// <returns>Le lieu de l'activité</returns>
        public Lieu getLieu() { return lieu; }

        /// <summary>
        /// Permet de connaître le TypeActivite de l'Activite
        /// </summary>
        /// <returns>Le TypeActivite de l'Activite</returns>
        public TypeActivite getTypeActivite() { return typeActivite; }

        /// <summary>
        /// Redéfini l'état de l'activité
        /// </summary>
        /// <param name="etat">Un IEtat</param>
        public void setEtat(IEtat etat) { this.etat = etat; }

        /// <summary>
        /// Redéfini le transport de l'activité
        /// </summary>
        /// <param name="transport">Un ITransport</param>
        public virtual void setTransport(ITransport transport) {  }

        /// <summary>
        /// Redéfini le lieu de l'activité
        /// </summary>
        /// <param name="l">Un lieu</param>
        public void setLieu(Lieu l) { this.lieu = l; }
        #endregion
    }
}
