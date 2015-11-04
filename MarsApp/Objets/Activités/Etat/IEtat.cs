using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'état d'avancement
    /// </summary>
    public interface IEtat
    {
        /// <summary>
        /// Retourne l'état de l'activité
        /// </summary>
        String etat();

        /// <summary>
        /// Retourne la couleur associée à l'état
        /// </summary>
        int[] couleur();

        /// <summary>
        /// Indique si on peut modifier l'objet en fonction de l'état
        /// </summary>
        /// <returns></returns>
        bool modifiable();
    }
}
