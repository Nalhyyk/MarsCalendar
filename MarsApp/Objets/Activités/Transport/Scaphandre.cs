using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarsApp
{
    /// <summary>
    /// Déplacement en extérieur à l'aide d'un scaphandre
    /// </summary>
    class Scaphandre : ITransport
    {
        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Scaphandre()
        {

        }
        #endregion

        public Bitmap deplacement()
        {
            return Properties.Resources.scaphandre;
        }


        public string nomTransport()
        {
            return "Scaphandre";
        }
    }
}
