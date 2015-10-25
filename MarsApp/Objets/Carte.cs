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
        private Lieu habitat;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Carte()
        {
            activitesRealisees = new List<Activite>();
            habitat = new Lieu(0, 0);
        }
    }
}
