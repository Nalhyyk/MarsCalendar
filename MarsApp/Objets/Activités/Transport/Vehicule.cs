using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Déplacement en extérieur à l'aide d'un véhicule
    /// </summary>
    class Vehicule : ITransport
    {
        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Vehicule()
        {

        }
        #endregion

        public void deplacement()
        {
            Console.WriteLine("Véhicule");
        }
    }
}
