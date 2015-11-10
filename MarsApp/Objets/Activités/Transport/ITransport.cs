using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarsApp
{
    /// <summary>
    /// Transport utilisé
    /// </summary>
    public interface ITransport
    {
        /// <summary>
        /// Renvoie l'image du mode de déplacement
        /// </summary>
        Bitmap deplacement();
    }
}
