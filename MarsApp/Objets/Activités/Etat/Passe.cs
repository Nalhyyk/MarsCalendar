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
            return "Passé";
        }

        public int[] couleur()
        {
            return new int[] { 199, 195, 199};
        }

        public bool modifiable()
        {
            return false;
        }
    }
}
