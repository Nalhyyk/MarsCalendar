using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Transport utilisé
    /// </summary>
    public interface ITransport
    {
        /// <summary>
        /// Permet de se déplacer
        /// </summary>
        void deplacement();
    }
}
