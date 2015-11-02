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
        private IEtat etat;
        private List<Activite> listeActivites;
        private String rapport;
        private bool journeeExterieure;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Journee() : this(0, "", new Future(), false) {}

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="numero">Numéro de la journée</param>
        public Journee(int numero) : this(numero, "", new Future(), false) { }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="numero">Le numéro de la journée</param>
        /// <param name="rapport">Le rapport de la journée</param>
        public Journee(int numero, String rapport, IEtat etat, bool journeeExterieure)
        {
            this.numero = numero;
            this.rapport = rapport;
            this.etat = etat;
            this.journeeExterieure = journeeExterieure;
            listeActivites = new List<Activite>();
            ajouterActivite(new Activite(new TypeActivite("Dormir"), "", new TimeMartien(0), new TimeMartien(7), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Manger"), "", new TimeMartien(7), new TimeMartien(8), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Privé"), "", new TimeMartien(8), new TimeMartien(12), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Manger"), "", new TimeMartien(12), new TimeMartien(14), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Privé"), "", new TimeMartien(14), new TimeMartien(19), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Manger"), "", new TimeMartien(19), new TimeMartien(21), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Privé"), "", new TimeMartien(21), new TimeMartien(23), new Lieu(0, 0)));
            ajouterActivite(new Activite(new TypeActivite("Dormir"), "", new TimeMartien(23), new TimeMartien(24, 40), new Lieu(0, 0)));
        }

        /// <summary>
        /// Ajouter une Activite
        /// </summary>
        /// <param name="a">Une Activite</param>
        public void ajouterActivite(Activite a)
        {
            listeActivites.Add(a);

            if (a.isActiviteExterieure())
                journeeExterieure = true;
        }

        /// <summary>
        /// Supprimer une Activite
        /// </summary>
        /// <param name="a">Une Activite</param>
        public void supprimerActivite(Activite d)
        {
            listeActivites.Remove(d);
            journeeExterieure = mettreAJourJourneeExterieure();
        }

        public bool mettreAJourJourneeExterieure()
        {
            foreach (Activite a in listeActivites)
                if (a.isActiviteExterieure())
                    return true;
            return false;
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

        public int[] couleurJournee()
        {
            return etat.couleur();
        }

        /// <summary>
        /// Définit la journée comme étant passée
        /// </summary>
        public void journeePassee()
        {
            etat = new Passee();
        }

        /// <summary>
        /// Définit la journée comme étant en cours
        /// </summary>
        public void journeeEnCours()
        {
            etat = new EnCours();
        }

        /// <summary>
        /// Définit la journée comme étant à venir
        /// </summary>
        public void journeeAVenir()
        {
            etat = new Future();
        }

        public Activite trouverActivite(int heure)
        {
            foreach (Activite a in listeActivites)
            {
                if (a.getHeureDebut().getHeures() <= heure && (a.getHeureFin().getHeures() > heure || a.getHeureFin().getHeures() == 0))
                    return a;
            }

            return null;
        }

        public bool isJourneeExterieure()
        {
            return journeeExterieure;
        }

        public void setJourneeExterieure(bool journeeExterieure)
        {
            this.journeeExterieure = journeeExterieure;
        }

        public List<Activite> getActivites() { return listeActivites; }

        public int getNumero() { return numero; }
    }
}
