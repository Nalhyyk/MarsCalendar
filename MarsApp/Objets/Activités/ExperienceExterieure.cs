using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarsApp
{
    /// <summary>
    /// Activité d'expérience se passant en extérieur
    /// </summary>
    public class ExperienceExterieure : Activite
    {
        #region Constructeurs

        private ITransport transport;

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="typeActivite">Type de l'Activite</param>
        /// <param name="description">Description de l'Activite</param>
        /// <param name="debut">Date de début de l'Activite</param>
        /// <param name="fin">Date de fin de l'Activite</param>
        /// <param name="lieu">Lieu de l'Activite</param>
        public ExperienceExterieure(TypeActivite typeActivite, String description, TimeMartien debut, TimeMartien fin, Lieu lieu)
            : this(typeActivite, description, debut, fin, lieu, new Scaphandre())
        {
            
        }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="typeActivite">Type de l'Activite</param>
        /// <param name="description">Description de l'Activite</param>
        /// <param name="debut">Date de début de l'Activite</param>
        /// <param name="fin">Date de fin de l'Activite</param>
        /// <param name="lieu">Lieu de l'Activite</param>
        /// <param name="transport">Moyen de transport pour l'Activite</param>
        public ExperienceExterieure(TypeActivite typeActivite, String description, TimeMartien debut, TimeMartien fin, Lieu lieu, ITransport transport)
            : base(typeActivite, description, debut, fin, lieu)
        {
            this.transport = transport;
        }

        /// <summary>
        /// Constructeur par copie
        /// </summary>
        /// <param name="ee">Une ExperienceExterieure</param>
        public ExperienceExterieure(ExperienceExterieure ee) : base(ee)
        {
            transport = new Scaphandre();
        }
        #endregion

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
            return false;
        }

        public override bool isExperience()
        {
            return true;
        }

        public String nomTransport()
        {
            return transport.nomTransport();
        }
        #endregion
    }
}
