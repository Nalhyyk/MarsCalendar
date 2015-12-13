using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Regroupe des activités
    /// </summary>
    public class Domaine
    {
        private String nom;
        private List<TypeActivite> listeActivites;
        private int[] couleur;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom du domaine</param>
        public Domaine(String nom) : this(nom, new int[]{0, 0, 0})
        {
            
        }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom du domaine</param>
        /// <param name="couleur">COuleur du domaine</param>
        public Domaine(String nom, int[] couleur)
        {
            this.nom = nom;
            listeActivites = new List<TypeActivite>();
            this.couleur = couleur;
        }
        #endregion

        /// <summary>
        /// Ajouter une activité
        /// </summary>
        /// <param name="a">Un type d'activité</param>
        public void ajouterActivite(TypeActivite a)
        {
            listeActivites.Add(a);
        }

        /// <summary>
        /// Supprimer une activité
        /// </summary>
        /// <param name="a">Un type d'activité</param>
        public void supprimerActivite(TypeActivite a)
        {
            listeActivites.Remove(a);
        }

        /// <summary>
        /// Permet d'ajouter le nombre d'activités présent dans le domaine à la valeur passée par référence
        /// </summary>
        /// <param name="nbElements">Un nombre d'éléments</param>
        public void nbTypeActivite(ref int nbElements)
        {
            nbElements += listeActivites.Count;
        }

        /// <summary>
        /// Affichage de la classe Domaine
        /// </summary>
        /// <returns>nom</returns>
        public override string ToString()
        {
            return nom;
        }

        #region Accesseurs
        /// <summary>
        /// Renvoie les types d'activités du Domaine
        /// </summary>
        /// <returns>Les types d'activités du Domaine</returns>
        public List<TypeActivite> getActivites() { return listeActivites; }

        /// <summary>
        /// Renvoie les noms des activités du Domaine
        /// </summary>
        /// <returns>Les noms des activités du Domaine</returns>
        public List<String> getNomActivites()
        {
            List<String> noms = new List<String>();
            foreach (TypeActivite a in listeActivites)
                noms.Add(a.getNom());
            return noms;
        }

        /// <summary>
        /// Renvoie le nom du Domaine
        /// </summary>
        /// <returns>Le nom du Domaine</returns>
        public String getNom() { return nom; }

        /// <summary>
        /// Renvoie la couleur du domaine
        /// </summary>
        /// <returns>La couleur du domaine</returns>
        public int[] getCouleur() { return couleur; }
        #endregion
    }
}
