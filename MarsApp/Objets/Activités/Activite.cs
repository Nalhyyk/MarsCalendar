using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Classe regroupant les informations d'une activité
    /// </summary>
    public class Activite
    {
        private IEtat etat;
        private TimeMartien timeMartien;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Activite()
        {
            etat = new ActiviteFuture();
            timeMartien = new TimeMartien();
        }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="tm">Un TimeMartien</param>
        public Activite(TimeMartien tm)
        {
            etat = new ActiviteFuture();
            this.timeMartien = tm;
        }

        /// <summary>
        /// Affiche l'état de l'activité
        /// </summary>
        public void etatActivite()
        {
            etat.etat();
        }

        /// <summary>
        /// Définit l'activité comme étant passée
        /// </summary>
        public void activitePassee()
        {
            etat = new ActivitePassee();
        }

        /// <summary>
        /// Définit l'activité comme étant en cours
        /// </summary>
        public void activiteEnCours()
        {
            etat = new ActiviteEnCours();
        }

        /// <summary>
        /// Définit l'activité comme étant à venir
        /// </summary>
        public void activiteAVenir()
        {
            etat = new ActiviteFuture();
        }
    }
}
