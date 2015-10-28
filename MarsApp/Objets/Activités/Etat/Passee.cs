using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'activité/Journée a eu lieu
    /// </summary>
    class Passee : IEtat
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Passee()
        {

        }

        public void etat()
        {
            Console.WriteLine("Passée");
        }


        public int[] couleur()
        {
            return new int[] { 199, 195, 199};
        }
    }
}
