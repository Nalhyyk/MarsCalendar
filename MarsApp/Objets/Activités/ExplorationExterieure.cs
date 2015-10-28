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
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom de l'Activite</param>
        /// <param name="description">Description de l'Activite</param>
        /// <param name="debut">Date de début de l'Activite</param>
        /// <param name="fin">Date de fin de l'Activite</param>
        /// <param name="lieu">Lieu de l'Activite</param>
        public ExplorationExterieure(String nom, String description, TimeMartien debut, TimeMartien fin, Lieu lieu) 
            : base(nom, description, debut, fin, lieu)
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

        public override bool isActiviteExterieure()
        {
            return true;
        }
    }
}
