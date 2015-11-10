using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Type d'une activité
    /// </summary>
    public class TypeActivite : IComparer<TypeActivite>
    {
        private String nom;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom du type d'activité</param>
        public TypeActivite(String nom)
        {
            this.nom = nom;
        }
        #endregion

        public int Compare(TypeActivite x, TypeActivite y)
        {
            if (String.Equals(x.nom, y.nom))
                return 0;
            else
                return -1;
        }

        #region Accesseurs
        /// <summary>
        /// Permet d'avoir le nom du type d'activité
        /// </summary>
        /// <returns>Le nom du type d'activité</returns>
        public String getNom() { return nom; }
        #endregion
    }
}
