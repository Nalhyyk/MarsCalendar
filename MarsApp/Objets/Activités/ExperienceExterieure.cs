﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Activité d'expérience se passant en extérieur
    /// </summary>
    public class ExperienceExterieure : Activite
    {
        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="typeActivite">Type de l'Activite</param>
        /// <param name="description">Description de l'Activite</param>
        /// <param name="debut">Date de début de l'Activite</param>
        /// <param name="fin">Date de fin de l'Activite</param>
        /// <param name="lieu">Lieu de l'Activite</param>
        public ExperienceExterieure(TypeActivite typeActivite, String description, TimeMartien debut, TimeMartien fin, Lieu lieu)
            : base(typeActivite, description, debut, fin, lieu)
        {

        }

        /// <summary>
        /// Constructeur par copie
        /// </summary>
        /// <param name="ee">Une ExperienceExterieure</param>
        public ExperienceExterieure(ExperienceExterieure ee) : base(ee)
        {

        }
        #endregion

        #region Accesseurs
        public override bool isActiviteExterieure()
        {
            return true;
        }

        public override bool isExploration()
        {
            return false;
        }
        #endregion
    }
}
