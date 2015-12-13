using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MarsApp
{
    /// <summary>
    /// Gestion d'un Astronaute
    /// </summary>
    public class Astronaute
    {
        private String nom;
        private String prenom;
        private int age;

        private Dictionary<int, Journee> journeesMission;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom de l'Astronaute</param>
        /// <param name="prenom">Prénom de l'Astronaute</param>
        /// <param name="age">Age de l'Astronaute</param>
        public Astronaute(String nom, String prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            journeesMission = new Dictionary<int, Journee>();
        }
        #endregion

        /// <summary>
        /// Permet de créer un emploi du temps pour l'astronaute
        /// </summary>
        public void creerEdT(int numJour)
        {
            for (int i = 1; i < 501; ++i)
                journeesMission[i] = new Journee(i);

            // Mise à jour des jours : passés | en cours | à venir
            for (int i = 1; i < numJour; ++i)
                journeesMission[i].journeePassee();
            journeesMission[numJour].journeeEnCours();
        }

        /// <summary>
        /// Texte affiché pour la classe
        /// </summary>
        /// <returns>nom prénom</returns>
        public override string ToString()
        {
            return nom + " " + prenom;
        }

        /// <summary>
        /// Permet de compter le nombre de journées, et le nombre d'activités par journée
        /// </summary>
        /// <param name="nbElements">Nombre d'éléments</param>
        public void nbJournees(ref int nbElements)
        {
            nbElements += journeesMission.Count;

            for (int i = 1; i < journeesMission.Count + 1; ++i)
                nbElements += journeesMission[i].getActivites().Count;
        }

        #region Génération XML
        /// <summary>
        /// Permet de générer la partie XML de Astronaute
        /// </summary>
        /// <param name="xmlDoc">XmlDocument global</param>
        /// <param name="xmlDocActs">XmlDocument pour les activités de base</param>
        /// <param name="astronaute">Le noeud de l'astronaute</param>
        /// <param name="acts">Le noeud de l'activité (base)</param>
        /// <param name="progression">L'interface de progression</param>
        public void genererXML(XmlDocument xmlDoc, XmlDocument xmlDocActs, XmlNode astronaute, XmlNode acts, Progression progression)
        {
            XmlNode nom = xmlDoc.CreateElement("Nom");
            nom.InnerText = this.nom;
            astronaute.AppendChild(nom);

            XmlNode prenom = xmlDoc.CreateElement("Prenom");
            prenom.InnerText = this.prenom;
            astronaute.AppendChild(prenom);

            XmlNode age = xmlDoc.CreateElement("Age");
            age.InnerText = this.age.ToString();
            astronaute.AppendChild(age);

            XmlNode journees = xmlDoc.CreateElement("JourneesMission");
            astronaute.AppendChild(journees);

            for (int i = 1; i <= journeesMission.Count; ++i)
            {
                XmlNode journee = xmlDoc.CreateElement("Journee");
                journees.AppendChild(journee);

                journeesMission[i].genererXML(xmlDoc, xmlDocActs, journee, acts, progression);
                progression.incrementer();
            }
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Permet d'obtenir l'emploi du temps de l'astronaute
        /// </summary>
        /// <returns>L'emploi du temps de l'astronaute</returns>
        public Dictionary<int, Journee> getJourneesMission() { return journeesMission; }

        /// <summary>
        /// Permet de définir l'emploi du temps de l'astronaute
        /// </summary>
        /// <param name="mission">Un dictionnaire de Journee</param>
        public void setJourneesMission(Dictionary<int, Journee> mission) { this.journeesMission = mission; }

        /// <summary>
        /// Permet d'obtenir le nom de l'astronaute
        /// </summary>
        /// <returns>Le nom de l'astronaute</returns>
        public String getNom() { return nom; }

        /// <summary>
        /// Permet d'obtenir le prénom de l'astronaute
        /// </summary>
        /// <returns>Le prénom de l'astronaute</returns>
        public String getPrenom() { return prenom; }

        /// <summary>
        /// Permet d'obtenir l'âge de l'astronaute
        /// </summary>
        /// <returns>L'âge de l'astronaute</returns>
        public int getAge() { return age; }

        /// <summary>
        /// Permet de redéfinir le nom de l'astronaute
        /// </summary>
        /// <param name="nom">Le nom de l'astronaute</param>
        public void setNom(String nom) { this.nom = nom; }

        /// <summary>
        /// Permet de redéfinir le prénom de l'astronaute
        /// </summary>
        /// <param name="prenom">Le prénom de l'astronaute</param>
        public void setPrenom(String prenom) { this.prenom = prenom; }

        /// <summary>
        /// Permet de redéfinir l'âge de l'astronaute
        /// </summary>
        /// <param name="age">L'âge de l'astronaute</param>
        public void setAge(int age) { this.age = age; }

        /// <summary>
        /// Permet d'obtenir la liste des journées dans une List (et non un Dictionary)
        /// </summary>
        /// <returns>La liste des journées</returns>
        public List<Journee> getJourneesNonDictionary()
        {
            List<Journee> journees = new List<Journee>();

            for (int i = 1; i <= 500; ++i)
                journees.Add(journeesMission[i]);
            return journees;
        }
        #endregion
    }
}
