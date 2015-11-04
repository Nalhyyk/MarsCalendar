using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'activité/Journée va avoir lieu
    /// </summary>
    class Futur : IEtat
    {
        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Futur()
        {

        }
        #endregion

        public String etat()
        {
            return "Futur";
        }


        public int[] couleur()
        {
            return new int[] { 51, 184, 121};
        }


        public bool modifiable()
        {
            return true;
        }
    }
}
