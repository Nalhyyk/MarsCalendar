using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MarsApp
{
    /// <summary>
    /// Type d'une activité
    /// </summary>
    public class TypeActivite
    {
        private String nom;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom du type d'activité</param>
        public TypeActivite(String nom)
        {
            this.nom = nom;
        }
        #endregion

        #region Génération XML
        public void genererXML(XmlDocument xmlDoc, XmlNode typeActivite)
        {
            XmlNode nom = xmlDoc.CreateElement("Nom");
            typeActivite.AppendChild(nom);
            nom.InnerText = this.nom;
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Permet d'avoir le nom du type d'activité
        /// </summary>
        /// <returns>Le nom du type d'activité</returns>
        public String getNom() { return nom; }
        #endregion
    }
}
