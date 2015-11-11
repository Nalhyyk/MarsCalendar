using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarsApp
{
    /// <summary>
    /// Activité d'exploration se passant en extérieur
    /// </summary>
    public class ExplorationExterieure : Activite
    {
        private ITransport transport;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="typeActivite">Type de l'Activite</param>
        /// <param name="description">Description de l'Activite</param>
        /// <param name="debut">Date de début de l'Activite</param>
        /// <param name="fin">Date de fin de l'Activite</param>
        /// <param name="lieu">Lieu de l'Activite</param>
        /// <param name="transport">Moyen de transport pour l'Activite</param>
        public ExplorationExterieure(TypeActivite typeActivite, String description, TimeMartien debut, TimeMartien fin, Lieu lieu, ITransport transport)
            : base(typeActivite, description, debut, fin, lieu)
        {
            this.transport = transport;
        }

        /// <summary>
        /// Constructeur par copie
        /// </summary>
        /// <param name="ee">Une ExplorationExterieure</param>
        public ExplorationExterieure(ExplorationExterieure ee) : base(ee)
        {
            this.transport = ee.transport;
        }
        #endregion

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
        public Bitmap deplacement()
        {
            return transport.deplacement();
        }

        #region Accesseurs
        public override bool isActiviteExterieure()
        {
            return true;
        }

        public override bool isExploration()
        {
            return true;
        }

        public override bool isExperience()
        {
            return false;
        }

        public String nomTransport()
        {
            return transport.nomTransport();
        }
        #endregion
    }
}
