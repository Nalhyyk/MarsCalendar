using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'activité/Journée est en cours
    /// </summary>
    class EnCours : IEtat
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public EnCours()
        {

        }

        public void etat()
        {
            Console.WriteLine("En cours");
        }


        public int[] couleur()
        {
            return new int[] { 2, 154, 229 };
        }


        public bool modifiable()
        {
            return true;
        }
    }
}
