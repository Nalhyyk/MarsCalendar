using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Activité d'exploration se passant en extérieur
    /// </summary>
    public class ExplorationExterieure : Activite
    {
        private ITransport transport;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ExplorationExterieure() 
            : base()
        {
            transport = new Scaphandre();
        }

        /// <summary>
        /// Définit le déplacement comme étant à pieds
        /// </summary>
        public void deplacementAPieds()
        {
            transport = new Scaphandre();
        }

        /// <summary>
        /// Définit le déplacement comme étant en véhicule
        /// </summary>
        public void deplacementEnVehicule()
        {
            transport = new Vehicule();
        }

        /// <summary>
        /// Moyen de déplacement utilisé pour l'exploration
        /// </summary>
        public void deplacement()
        {
            transport.deplacement();
        }
    }
}
