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
        private List<Activite> listeActivites;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Domaine()
        {
            listeActivites = new List<Activite>();
        }

        /// <summary>
        /// Ajouter une Activite
        /// </summary>
        /// <param name="a">Une Activite</param>
        public void ajouterActivite(Activite a)
        {
            listeActivites.Add(a);
        }

        /// <summary>
        /// Supprimer une Activite
        /// </summary>
        /// <param name="a">Une Activite</param>
        public void supprimerActivite(Activite a)
        {
            listeActivites.Remove(a);
        }
    }
}
