using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Gestion d'une journée
    /// </summary>
    public class Journee
    {
        private int numero;
        private List<Domaine> listeDomaineActivites;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Journee() : this(0) {}

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="numero">Le numéro de la journée</param>
        public Journee(int numero)
        {
            this.numero = numero;
            listeDomaineActivites = new List<Domaine>();
        }

        /// <summary>
        /// Ajouter un Domaine d'Activite
        /// </summary>
        /// <param name="d">Un Domaine</param>
        public void ajouterDomaine(Domaine d)
        {
            listeDomaineActivites.Add(d);
        }

        /// <summary>
        /// Supprimer un Domaine d'Activite
        /// </summary>
        /// <param name="d">Un Domaine</param>
        public void supprimerDomaine(Domaine d)
        {
            listeDomaineActivites.Remove(d);
        }
    }
}
