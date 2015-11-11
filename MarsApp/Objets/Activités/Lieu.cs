using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

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

        #region Génération XML
        public void genererXML(XmlDocument xmlDoc, XmlNode lieu)
        {
            XmlNode x = xmlDoc.CreateElement("X");
            x.InnerText = this.x.ToString();
            lieu.AppendChild(x);

            XmlNode y = xmlDoc.CreateElement("Y");
            y.InnerText = this.y.ToString();
            lieu.AppendChild(y);
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Permet de récupérer la coordonnée en x du lieu (échelle normale)
        /// </summary>
        /// <returns>La coordonnée en x du lieu</returns>
        public int getX() { return x; }

        /// <summary>
        /// Permet de récupérer la coordonnée en x du lieu (échelle réduite)
        /// </summary>
        /// <returns>La coordonnée en x du lieu</returns>
        public int getXReduit() { return (int) Math.Round((x + Constantes.POSITION_BASE_X) / Constantes.RAPPORT_CARTES, 0); }

        /// <summary>
        /// Permet de récupérer la coordonnée en y du lieu (échelle normale)
        /// </summary>
        /// <returns>La coordonnée en y du lieu</returns>
        public int getY() { return y; }

        /// <summary>
        /// Permet de récupérer la coordonnée en y du lieu (échelle réduite)
        /// </summary>
        /// <returns>La coordonnée en y du lieu</returns>
        public int getYReduit() { return (int) Math.Round((y + Constantes.POSITION_BASE_Y) / Constantes.RAPPORT_CARTES, 0); }

        /// <summary>
        /// Permet de redéfinir le lieu
        /// </summary>
        /// <param name="e">Un MouseEventArgs</param>
        public void setLieu(MouseEventArgs e)
        {
            this.x = e.X;
            this.y = e.Y;
            convertirPosition(ref x, ref y);
        }
        #endregion
    }
}
