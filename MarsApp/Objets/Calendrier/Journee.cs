using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Gestion d'une journée
    /// </summary>
    public class Journee
    {
        private int numero;
        private List<Activite> listeActivites;
        private String rapport;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Journee() : this(0, "") {}

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="numero">Numéro de la journée</param>
        public Journee(int numero) : this(numero, "") {}

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="numero">Le numéro de la journée</param>
        /// <param name="rapport">Le rapport de la journée</param>
        public Journee(int numero, String rapport)
        {
            this.numero = numero;
            this.rapport = rapport;
            listeActivites = new List<Activite>();
            listeActivites.Add(new Activite("Repos", "", new TimeMartien(0), new TimeMartien(7)));
            listeActivites.Add(new Activite("Repas", "", new TimeMartien(7), new TimeMartien(8)));
            listeActivites.Add(new Activite("Privé", "", new TimeMartien(8), new TimeMartien(12)));
            listeActivites.Add(new Activite("Repas", "", new TimeMartien(12), new TimeMartien(14)));
            listeActivites.Add(new Activite("Privé", "", new TimeMartien(14), new TimeMartien(19)));
            listeActivites.Add(new Activite("Repas", "", new TimeMartien(19), new TimeMartien(21)));
            listeActivites.Add(new Activite("Privé", "", new TimeMartien(21), new TimeMartien(23)));
            listeActivites.Add(new Activite("Repos", "", new TimeMartien(23), new TimeMartien(24, 40)));
        }

        /// <summary>
        /// Ajouter une Activite
        /// </summary>
        /// <param name="a">Une Activite</param>
        public void ajouterActivite(Activite a)
        {
            listeActivites.Add(a);
        }

        /// <summary>
        /// Supprimer une Activite
        /// </summary>
        /// <param name="a">Une Activite</param>
        public void supprimerActivite(Activite d)
        {
            listeActivites.Remove(d);
        }

        /// <summary>
        /// Modifie le rapport de la journée. Il doit faire 1000 caractères maximum
        /// </summary>
        /// <param name="rapport">Rapport de la journée</param>
        /// <returns>false si le rapport fait plus de 1000 caractères, true sinon</returns>
        public bool setRapport(String rapport)
        {
            if (rapport.Length <= Constantes.LIMITE_RAPPORT_JOURNEE)
                this.rapport = rapport;
            else
                return false;

            return true;
        }
    }
}
