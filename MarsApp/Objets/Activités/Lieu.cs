using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarsApp
{
    /// <summary>
    /// Gestion du lieu d'une Activite
    /// </summary>
    public class Lieu
    {
        private int x;
        private int y;

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="x">Coordonnée sur l'axe des abscisses</param>
        /// <param name="y">Coordonnée sur l'axe des ordonnées</param>
        public Lieu(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="e">Evènement lié à la souris</param>
        public Lieu(MouseEventArgs e)
        {
            this.x = e.X;
            this.y = e.Y;
        }
    }
}
