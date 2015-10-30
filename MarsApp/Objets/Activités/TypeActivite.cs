using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Type d'une activité
    /// </summary>
    public class TypeActivite
    {
        private String nom;

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom du type d'activité</param>
        public TypeActivite(String nom)
        {
            this.nom = nom;
        }

        /// <summary>
        /// Permet d'avoir le nom du type d'activité
        /// </summary>
        /// <returns>Le nom du type d'activité</returns>
        public String getNom() { return nom; }
    }
}
