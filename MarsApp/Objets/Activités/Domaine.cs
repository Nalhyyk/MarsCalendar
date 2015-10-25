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
        private List<String> listeActivites;

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        public Domaine(String nom)
        {
            this.nom = nom;
            listeActivites = new List<String>();
        }

        /// <summary>
        /// Ajouter une activité
        /// </summary>
        /// <param name="a">Un nom d'activité</param>
        public void ajouterActivite(String a)
        {
            listeActivites.Add(a);
        }

        /// <summary>
        /// Supprimer une activité
        /// </summary>
        /// <param name="a">Un nom d'activité</param>
        public void supprimerActivite(String a)
        {
            listeActivites.Remove(a);
        }

        /// <summary>
        /// Renvoie le nom de toutes les activités du Domaine
        /// </summary>
        /// <returns>Le nom de toutes les activités du Domaine</String></returns>
        public List<String> getActivites() { return listeActivites; }
    }
}
