using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'activité a eu lieu
    /// </summary>
    class ActivitePassee : IEtat
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ActivitePassee()
        {

        }

        public void etat()
        {
            Console.WriteLine("Activité passée");
        }
    }
}
