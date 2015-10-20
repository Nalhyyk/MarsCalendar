using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Déplacement en extérieur à l'aide d'un scaphandre
    /// </summary>
    class Scaphandre : ITransport
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Scaphandre()
        {

        }

        public void deplacement()
        {
            Console.WriteLine("Scaphandre");
        }
    }
}
