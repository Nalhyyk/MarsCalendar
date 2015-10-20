using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'activité est en cours
    /// </summary>
    class ActiviteEnCours : IEtat
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ActiviteEnCours()
        {

        }

        public void etat()
        {
            Console.WriteLine("Activité en cours");
        }
    }
}
