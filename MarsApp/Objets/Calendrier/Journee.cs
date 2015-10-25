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

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Journee() : this(0) {}

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="numero">Le numéro de la journée</param>
        public Journee(int numero)
        {
            this.numero = numero;
            listeActivites = new List<Activite>();
            listeActivites.Add(new Activite("Sleeping", new TimeMartien(0), new TimeMartien(7)));
            listeActivites.Add(new Activite("Eating", new TimeMartien(7), new TimeMartien(8)));
            listeActivites.Add(new Activite("Private", new TimeMartien(8), new TimeMartien(12)));
            listeActivites.Add(new Activite("Eating", new TimeMartien(12), new TimeMartien(14)));
            listeActivites.Add(new Activite("Private", new TimeMartien(14), new TimeMartien(19)));
            listeActivites.Add(new Activite("Eating", new TimeMartien(19), new TimeMartien(21)));
            listeActivites.Add(new Activite("Private", new TimeMartien(21), new TimeMartien(23)));
            listeActivites.Add(new Activite("Sleeping", new TimeMartien(23), new TimeMartien(24, 40)));
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
    }
}
