using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'activité/Journée a eu lieu
    /// </summary>
    class Passe : IEtat
    {
        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Passe()
        {

        }
        #endregion

        public String etat()
        {
            return Constantes.ETAT_PASSE;
        }

        public int[] couleur()
        {
            return Constantes.COULEUR_PASSE;
        }

        public bool modifiable()
        {
            return false;
        }
    }
}
