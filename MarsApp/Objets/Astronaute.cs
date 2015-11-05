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
        private String age;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom de l'Astronaute</param>
        /// <param name="prenom">Prénom de l'Astronaute</param>
        /// <param name="age">Age de l'Astronaute</param>
        public Astronaute(String nom, String prenom, String age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }
        #endregion
    }
}
