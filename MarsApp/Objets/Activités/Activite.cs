using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Classe regroupant les informations d'une activité
    /// </summary>
    public class Activite
    {
        protected TypeActivite typeActivite;
        protected String description;
        protected IEtat etat;
        protected TimeMartien heureDebut;
        protected TimeMartien heureFin;
        protected List<Astronaute> listeAstronautes;
        protected Lieu lieu;

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
            etat = new Future();
            this.heureDebut = deb;
            this.heureFin = fin;
            listeAstronautes = new List<Astronaute>();
            this.lieu = lieu;
        }

        public Activite(Activite a)
        {
            typeActivite = a.typeActivite;
            description = a.description;
            etat = a.etat;
            heureDebut = a.heureDebut;
            heureFin = a.heureFin;
            listeAstronautes = a.listeAstronautes;
            lieu = a.lieu;
        }

        /// <summary>
        /// Affiche l'état de l'activité
        /// </summary>
        public void etatActivite()
        {
            etat.etat();
        }

        /// <summary>
        /// Définit l'activité comme étant passée
        /// </summary>
        public void activitePassee()
        {
            etat = new Passee();
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
            etat = new Future();
        }

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

        public virtual bool isExploration()
        {
            return false;
        }

        public bool isModifiable()
        {
            return etat.modifiable();
        }

        public TimeMartien getHeureDebut() { return heureDebut; }
        public TimeMartien getHeureFin() { return heureFin; }
        public String getNom() { return typeActivite.getNom(); }
        public void setHeureDebut(TimeMartien tm) { this.heureDebut = tm; }
        public void setHeureFin(TimeMartien tm) { this.heureFin = tm; }
        public TimeMartien getDuree() { return heureFin - heureDebut; }
        public String getDescription() { return description; }
        public Lieu getLieu() { return lieu; }
    }
}
