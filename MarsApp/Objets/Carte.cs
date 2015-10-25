using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp.Objets
{
    /// <summary>
    /// Carte de la planète
    /// </summary>
    public class Carte
    {
        private List<Activite> activitesRealisees;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Carte()
        {
            activitesRealisees = new List<Activite>();
        }
    }
}
