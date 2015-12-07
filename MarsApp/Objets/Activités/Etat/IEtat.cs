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
        /// <returns>La couleur associée à l'état au format RGB</returns>
        int[] couleur();

        /// <summary>
        /// Indique si on peut modifier l'objet en fonction de l'état
        /// </summary>
        /// <returns>Vrai le l'objet est modificable selon l'état, faux sinon</returns>
        bool modifiable();
    }
}
