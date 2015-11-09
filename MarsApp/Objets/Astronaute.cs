using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Gestion d'un Astronaute
    /// </summary>
    public class Astronaute
    {
        private String nom;
        private String prenom;
        private int age;

        private Dictionary<int, Journee> journeesMission;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom de l'Astronaute</param>
        /// <param name="prenom">Prénom de l'Astronaute</param>
        /// <param name="age">Age de l'Astronaute</param>
        public Astronaute(String nom, String prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            journeesMission = new Dictionary<int, Journee>();
        }
        #endregion

        /// <summary>
        /// Permet de créer un emploi du temps pour l'astronaute
        /// </summary>
        public void creerEdT(int numJour)
        {
            for (int i = 1; i < 501; ++i)
                journeesMission[i] = new Journee(i);

            // Mise à jour des jours : passés | en cours | à venir
            for (int i = 1; i < numJour; ++i)
                journeesMission[i].journeePassee();
            journeesMission[numJour].journeeEnCours();
        }

        public override string ToString()
        {
            return nom + " " + prenom;
        }

        #region Accesseurs
        /// <summary>
        /// Permet d'obtenir l'emploi du temps de l'astronaute
        /// </summary>
        /// <returns>L'emploi du temps de l'astronaute</returns>
        public Dictionary<int, Journee> getJourneesMission() { return journeesMission; }
        #endregion
    }
}
