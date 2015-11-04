using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Regroupe des activités
    /// </summary>
    public class Domaine
    {
        private String nom;
        private List<TypeActivite> listeActivites;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        public Domaine(String nom)
        {
            this.nom = nom;
            listeActivites = new List<TypeActivite>();
        }
        #endregion

        /// <summary>
        /// Ajouter une activité
        /// </summary>
        /// <param name="a">Un type d'activité</param>
        public void ajouterActivite(TypeActivite a)
        {
            listeActivites.Add(a);
        }

        /// <summary>
        /// Supprimer une activité
        /// </summary>
        /// <param name="a">Un type d'activité</param>
        public void supprimerActivite(TypeActivite a)
        {
            listeActivites.Remove(a);
        }

        #region Accesseurs
        /// <summary>
        /// Renvoie les types d'activités du Domaine
        /// </summary>
        /// <returns>Les types d'activités du Domaine</returns>
        public List<TypeActivite> getActivites() { return listeActivites; }

        /// <summary>
        /// Renvoie le nom du Domaine
        /// </summary>
        /// <returns>Le nom du Domaine</returns>
        public String getNom() { return nom; }
        #endregion
    }
}
