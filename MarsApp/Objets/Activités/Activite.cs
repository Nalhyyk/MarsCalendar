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
        private String nom;
        private String description;
        private IEtat etat;
        private TimeMartien heureDebut;
        private TimeMartien heureFin;
        private List<Astronaute> listeAstronautes;
        private Lieu lieu;

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom de l'Activite</param>
        public Activite(String nom) : this(nom, "", new TimeMartien(), new TimeMartien(), new Lieu(0, 0)) {}

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom de l'Activite</param>
        /// <param name="description">Description de l'Activite</param>
        /// <param name="deb">Date de début de l'Activite</param>
        /// <param name="fin">Date de fin de l'Activite</param>
        /// <param name="lieu">Lieu de l'Activite</param>
        public Activite(String nom, String description, TimeMartien deb, TimeMartien fin, Lieu lieu)
        {
            this.nom = nom;
            this.description = description;
            etat = new ActiviteFuture();
            this.heureDebut = deb;
            this.heureFin = fin;
            listeAstronautes = new List<Astronaute>();
            this.lieu = lieu;
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
            etat = new ActivitePassee();
        }

        /// <summary>
        /// Définit l'activité comme étant en cours
        /// </summary>
        public void activiteEnCours()
        {
            etat = new ActiviteEnCours();
        }

        /// <summary>
        /// Définit l'activité comme étant à venir
        /// </summary>
        public void activiteAVenir()
        {
            etat = new ActiviteFuture();
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
    }
}
