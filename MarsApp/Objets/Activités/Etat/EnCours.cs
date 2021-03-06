﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'activité/Journée est en cours
    /// </summary>
    class EnCours : IEtat
    {
        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public EnCours()
        {

        }
        #endregion

        public String etat()
        {
            return Constantes.ETAT_ENCOURS;
        }

        public int[] couleur()
        {
            return Constantes.COULEUR_ENCOURS;
        }

        public bool modifiable()
        {
            return true;
        }
    }
}
