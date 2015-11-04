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

        #region Constructeurs
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
            convertirPosition(ref x, ref y);
        }
        #endregion

        public override string ToString()
        {
            return x + ";" + y;
        }

        /// <summary>
        /// Permet de convertir des coordonnées de la map réduite (en fonction
        /// de la taille de la map d'origine), et centre la base (700, 1000) en (0, 0)
        /// </summary>
        /// <param name="x">Coordonnées x de la map réduite</param>
        /// <param name="y">Coordonnées y de la map réduite</param>
        public static void convertirPosition(ref int x, ref int y)
        {
            x = (int) Math.Round(x * Constantes.RAPPORT_CARTES, 0) - Constantes.POSITION_BASE_X;
            y = (int) Math.Round(y * Constantes.RAPPORT_CARTES, 0) - Constantes.POSITION_BASE_Y;
        }

        public int getX() { return x; }
        public int getXReduit() { return (int) Math.Round((x + Constantes.POSITION_BASE_X) / Constantes.RAPPORT_CARTES, 0); }
        public int getY() { return y; }
        public int getYReduit() { return (int) Math.Round((y + Constantes.POSITION_BASE_Y) / Constantes.RAPPORT_CARTES, 0); }

        public void setLieu(MouseEventArgs e)
        {
            this.x = e.X;
            this.y = e.Y;
            convertirPosition(ref x, ref y);
        }
    }
}
