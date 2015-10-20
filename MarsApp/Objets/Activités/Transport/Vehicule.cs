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
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Vehicule()
        {

        }

        public void deplacement()
        {
            Console.WriteLine("Véhicule");
        }
    }
}
