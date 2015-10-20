using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'activité va avoir lieu
    /// </summary>
    class ActiviteFuture : IEtat
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ActiviteFuture()
        {

        }

        public void etat()
        {
            Console.WriteLine("Activité future");
        }
    }
}
