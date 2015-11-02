using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'activité/Journée va avoir lieu
    /// </summary>
    class Future : IEtat
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Future()
        {

        }

        public void etat()
        {
            Console.WriteLine("Future");
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
