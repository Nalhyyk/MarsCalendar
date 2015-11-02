using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// L'état d'avancement d'une activité
    /// </summary>
    public interface IEtat
    {
        /// <summary>
        /// Affiche l'état de l'activité
        /// </summary>
        void etat();

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
