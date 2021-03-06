﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MarsApp
{
    /// <summary>
    /// Temps martien (temps d'une journée : 24h40)
    /// </summary>
    public class TimeMartien
    {
        private int jours;
        private int heure;
        private int minute;
        private int seconde;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="heure">Heures</param>
        /// <param name="minute">Minutes</param>
        /// <param name="seconde">Secondes</param>
        public TimeMartien(int jours, int heure, int minute, int seconde)
        {
            this.heure = heure;
            this.minute = minute;
            this.seconde = seconde;
            this.jours = jours;
            ajouterTemps(0, 0, 0, 0); // On met le TimeMartien sous une forme 'convenable'
        }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="heure">Heures</param>
        /// <param name="minute">Minutes</param>
        public TimeMartien(int heure, int minute) : this(0, heure, minute, 0) { }
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="heure">Heures</param>
        public TimeMartien(int heure) : this(0, heure, 0, 0) { }
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public TimeMartien() : this(0, 0, 0, 0) { }
        #endregion

        #region AJOUT DE TEMPS
        /// <summary>
        /// Surcharge de l'opérateur +
        /// </summary>
        /// <param name="t1">TimeMartien à additionner</param>
        /// <param name="t2">Addition avec TimeMartien</param>
        /// <returns>Résultat addition</returns>
        public static TimeMartien operator +(TimeMartien t1, TimeMartien t2)
        {
            TimeMartien tR = new TimeMartien(0, t1.heure, t1.minute, t1.seconde);

            tR.ajouterTemps(t2);

            return tR;
        }
        /// <summary>
        /// Permet d'ajouter du temps au TimeMartien
        /// </summary>
        /// <param name="tm">Un TimeMartien</param>
        public void ajouterTemps(TimeMartien tm)
        {
            ajouterTemps(tm.jours, tm.heure, tm.minute, tm.seconde);
        }
        /// <summary>
        /// Permet d'ajouter du temps au TimeMartien
        /// </summary>
        /// <param name="heure">Heures</param>
        /// <param name="minute">Minutes</param>
        /// <param name="seconde">Secondes</param>
        public void ajouterTemps(int jour, int heure, int minute, int seconde)
        {
            // On ajoute toutes les h/m/s pour avoir une heure à réduire
            this.jours += jour;
            this.seconde += seconde;
            this.minute += minute;
            this.heure += heure;

            // On veut obtenir des secondes comprises entre 0 et 59
            this.minute += (int) this.seconde / 60;
            this.seconde %= 60;

            // On veut obtenir des minutes comprises entre 0 et 59
            this.heure += (int)this.minute / 60;
            this.minute %= 60;

            /* On veut obtenir des heures comprises entre 0 et 24, la limite étant 24h40
             * (au delà de 24h40, on retire 24h et 40m)
             */
            this.jours += (int)this.heure / 25;
            int diff = this.heure - (this.heure % 24);
            int nHeure = this.heure;
            this.heure = this.heure % 25;

            if (diff != 0 && diff != nHeure)
            {
                this.minute += 20 * (nHeure / 25);
                ajouterTemps(0, 0, 0, 0);
            }

            bool passage = false;

            // On traite toutes les heures/minutes négatives
            while (this.heure < 0 || this.minute < 0 || this.seconde < 0 || !passage)
            {
                passage = true;

                while (this.minute < 0)
                {
                    this.minute += 60;
                    --this.heure;
                }
            }
        }
        #endregion
        #region RETRAIT DE TEMPS
        /// <summary>
        /// Surcharge de l'opérateur -
        /// </summary>
        /// <param name="t1">TimeMartien à soustraire</param>
        /// <param name="t2">Soustraction avec TimeMartien</param>
        /// <returns>Résultat soustraction</returns>
        public static TimeMartien operator -(TimeMartien t1, TimeMartien t2)
        {
            TimeMartien tR = new TimeMartien(t1.jours, t1.heure, t1.minute, t1.seconde);

            tR.retirerTemps(t2);

            return tR;
        }
        /// <summary>
        /// Permet de retirer du temps au TimeMartien
        /// </summary>
        /// <param name="tm">Un TimeMartien</param>
        public void retirerTemps(TimeMartien tm)
        {
            retirerTemps(tm.jours, tm.heure, tm.minute, tm.seconde);
        }
        /// <summary>
        /// Permet de retirer du temps au TimeMartien
        /// </summary>
        /// <param name="heure">Heures</param>
        /// <param name="minute">Minutes</param>
        /// <param name="seconde">Secondes</param>
        public void retirerTemps(int jour, int heure, int minute, int seconde)
        {
            // On retire toutes les h/m/s pour avoir une heure à traiter
            bool passage = false;
            this.jours -= jour;
            this.seconde -= seconde;
            this.minute -= minute;
            this.heure -= heure;

            // Tant qu'on a des valeurs de temps négatives, on traite
            while (this.heure < 0 || this.minute < 0 || this.seconde < 0 || !passage)
            {
                passage = true;

                // On veut obtenir des secondes comprises entre 0 et 59
                while (this.seconde < 0)
                {
                    this.seconde += 60;
                    --this.minute;
                }

                // On veut obtenir des minutes comprises entre 0 et 59
                while (this.minute < 0)
                {
                    this.minute += 60;
                    --this.heure;
                }

                /* On veut obtenir des heures comprises entre 0 et 24, la limite étant 24h40
                 * (à chaque fois, on ajoute 25h-20m)
                 */
                while (this.heure < 0)
                {
                    this.heure += 25;
                    this.minute -= 20;
                    this.jours -= 1;
                }
            }
        }
        #endregion

        #region Autres surcharges d'opérateurs
        /// <summary>
        /// Surcharge de l'opérateur ==
        /// </summary>
        /// <param name="t1">TimeMartien</param>
        /// <param name="t2">TimeMartien</param>
        /// <returns>Résultat égal</returns>
        public static bool operator ==(TimeMartien t1, TimeMartien t2)
        {
            if (t1.getHeures() == t2.getHeures())
                if (t1.getMinutes() == t2.getMinutes())
                    if (t1.getSecondes() == t2.getSecondes())
                        return true;
            return false;
        }

        /// <summary>
        /// Permet de savoir quand deux TimeMartien sont égaux
        /// </summary>
        /// <param name="obj">Un TimeMartien</param>
        /// <returns>Vrai si les deux TImeMartien sont égaux, faux sinon</returns>
        public override bool Equals(object obj)
        {
            TimeMartien t2 = obj as TimeMartien;

            if (t2 != null)
            {
                if (this.getHeures() == t2.getHeures())
                    if (this.getMinutes() == t2.getMinutes())
                        if (this.getSecondes() == t2.getSecondes())
                            return true;
            }
            return false;
        }

        /// <summary>
        /// Surcharge du GetHashCode (lié au Equals)
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Surcharge de l'opérateur !=
        /// </summary>
        /// <param name="t1">TimeMartien</param>
        /// <param name="t2">TimeMartien</param>
        /// <returns>Résultat différent</returns>
        public static bool operator !=(TimeMartien t1, TimeMartien t2)
        {
            bool estPasNull = true;

            Object a1 = t1;
            Object a2 = t2;

            if (a1 == null || a2 == null)
                estPasNull = false;

            if (estPasNull)
            {
                if (t1.getHeures() != t2.getHeures())
                    return true;
                if (t1.getMinutes() != t2.getMinutes())
                    return true;
                if (t1.getSecondes() != t2.getSecondes())
                    return true;
                return false;
            }
            else
                if ((a1 == null && a2 != null) || (a1 != null && a2 == null))
                    return true;
            return false;
        }
        
        /// <summary>
        /// Surcharge de l'opérateur <
        /// </summary>
        /// <param name="t1">TimeMartien</param>
        /// <param name="t2">TimeMartien</param>
        /// <returns>Résultat inférieur</returns>
        public static bool operator <(TimeMartien t1, TimeMartien t2)
        {
            if (t1.getHeures() < t2.getHeures())
                return true;
            else if (t1.getHeures() == t2.getHeures())
                if (t1.getMinutes() < t2.getMinutes())
                    return true;
                else if (t1.getMinutes() == t2.getMinutes())
                    if (t1.getSecondes() < t2.getSecondes())
                        return true;
            return false;
        }

        /// <summary>
        /// Surcharge de l'opérateur >
        /// </summary>
        /// <param name="t1">TimeMartien</param>
        /// <param name="t2">TimeMartien</param>
        /// <returns>Résultat inférieur</returns>
        public static bool operator >(TimeMartien t1, TimeMartien t2)
        {
            if (t1.getHeures() > t2.getHeures())
                return true;
            else if (t1.getHeures() == t2.getHeures())
                if (t1.getMinutes() > t2.getMinutes())
                    return true;
                else if (t1.getMinutes() == t2.getMinutes())
                    if (t1.getSecondes() > t2.getSecondes())
                        return true;
            return false;
        }

        /// <summary>
        /// Surcharge de l'opérateur <=
        /// </summary>
        /// <param name="t1">TimeMartien</param>
        /// <param name="t2">TimeMartien</param>
        /// <returns>Résultat inférieur ou égal</returns>
        public static bool operator <=(TimeMartien t1, TimeMartien t2)
        {
            if (t1.getHeures() < t2.getHeures())
                return true;
            else if (t1.getHeures() == t2.getHeures())
                if (t1.getMinutes() < t2.getMinutes())
                    return true;
                else if (t1.getMinutes() == t2.getMinutes())
                    if (t1.getSecondes() <= t2.getSecondes())
                        return true;
            return false;
        }

        /// <summary>
        /// Surcharge de l'opérateur >=
        /// </summary>
        /// <param name="t1">TimeMartien</param>
        /// <param name="t2">TimeMartien</param>
        /// <returns>Résultat supérieur ou égal</returns>
        public static bool operator >=(TimeMartien t1, TimeMartien t2)
        {
            if (t1.getHeures() > t2.getHeures())
                return true;
            else if (t1.getHeures() == t2.getHeures())
                if (t1.getMinutes() > t2.getMinutes())
                    return true;
                else if (t1.getMinutes() == t2.getMinutes())
                    if (t1.getSecondes() >= t2.getSecondes())
                        return true;
            return false;
        }
        #endregion

        /// <summary>
        /// Permet de calculer le nombre de jours passés depuis le DateTime spécifié (en temps martien)
        /// </summary>
        /// <param name="dateDepart">Un DateTime</param>
        /// <returns>Le nombre de jours écoulés depuis la date spécifiée, en temps martien</returns>
        public static TimeMartien calculerJours(DateTime dateDepart)
        {
            DateTime dt = DateTime.Now;

            if (dt >= dateDepart)
            {
                long ticks = dt.Ticks - dateDepart.Ticks;
                TimeSpan ts = new TimeSpan(ticks);

                TimeMartien tm = new TimeMartien(0, 0, 0, (int)Math.Truncate(ts.TotalSeconds));

                return tm;
            }
            else
                return new TimeMartien(0, 0, 0, 0);
        }

        /// <summary>
        /// Permet de savoir si une activité se passe dans la période donnée
        /// </summary>
        /// <param name="debutActivite">Début de l'activité</param>
        /// <param name="finActivite">Fin de l'activité</param>
        /// <param name="heureDebut">Début de la période</param>
        /// <param name="heureFin">Fin de la période</param>
        /// <returns>Vrai si l'activité se passe dans la période, faux sinon</returns>
        public static bool sePasseDansPeriode(TimeMartien debutActivite, TimeMartien finActivite, TimeMartien heureDebut, TimeMartien heureFin)
        {
            if (finActivite.getHeures() == 0 && finActivite.getMinutes() == 0 && finActivite.getSecondes() == 0)
                finActivite = new TimeMartien(0, 24, 39, 59);

            if (heureFin.getHeures() == 0 && heureFin.getMinutes() == 0 && heureFin.getSecondes() == 0)
                heureFin = new TimeMartien(0, 24, 39, 59);

            bool dINFd = (debutActivite <= heureDebut);
            bool dSUPd = (debutActivite >= heureDebut);
            bool fINFf = (finActivite <= heureFin);
            bool fSUPf = (finActivite >= heureFin);
            bool dINFf = (debutActivite < heureFin || debutActivite.getJours() < heureFin.getJours());
            bool fSUPd = (finActivite > heureDebut || finActivite.getJours() > heureDebut.getJours());

            if (dINFd && fSUPf && dINFf && fSUPd)
                return true;
            else if (dSUPd && fINFf && dINFf && fSUPd)
                return true;
            else if (dSUPd && fSUPf && dINFf && fSUPd)
                return true;
            else if (dINFd && fINFf && dINFf && fSUPd)
                return true;
            return false;
        }

        /// <summary>
        /// Permet de calculer le nombre de minutes du temps martien
        /// </summary>
        /// <returns></returns>
        public int nbMinutes()
        {
            return heure * 60 + minute;
        }

        #region Génération XML
        /// <summary>
        /// Permet de générer la partie XML de TimeMartien
        /// </summary>
        /// <param name="xmlDoc">XmlDocument</param>
        /// <param name="heureMartienne">Noeud du TimeMartien</param>
        public void genererXML(XmlDocument xmlDoc, XmlNode heureMartienne)
        {
            heureMartienne.InnerText = nbMinutes().ToString();
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Permet de connaître l'heure du temps martien
        /// </summary>
        /// <returns>L'heure du temps martien</returns>
        public int getHeures() { return heure; }

        /// <summary>
        /// Permet de connaître les minutes du temps martien
        /// </summary>
        /// <returns>Les minutes du temps martien</returns>
        public int getMinutes() { return minute; }

        /// <summary>
        /// Permet de connaître les secondes du temps martien
        /// </summary>
        /// <returns>Les secondes du temps martien</returns>
        public int getSecondes() { return seconde; }

        /// <summary>
        /// Permet de redéfinir les jours du temps martien
        /// </summary>
        /// <param name="jours">Un nombre de jours</param>
        public void setJours(int jours) { this.jours = jours; }

        /// <summary>
        /// Permet de connaître les jours du temps martien
        /// </summary>
        /// <returns></returns>
        public int getJours() { return jours; }

        /// <summary>
        /// Permet d'obtenir le nombre total de minutes du temps martien
        /// </summary>
        /// <returns>Le nombre de minutes total</returns>
        public int getTotalMinutes()
        {
            int min = minute;
            minute = 0;

            while (heure > 0)
            {
                min += 60;
                heure--;
            }
            return min;
        }

        /// <summary>
        /// Permet d'obtenir les informations du temps martien, sans le jour de mission
        /// </summary>
        /// <returns>Informations sur le temps martien</returns>
        public String affichageSansJour() { return ((heure.ToString().Length == 1) ? "0" : "") + heure + ":" + ((minute.ToString().Length == 1) ? "0" : "") + minute + ":" + ((seconde.ToString().Length == 1) ? "0" : "") + seconde; }
        #endregion

        /// <summary>
        /// Texte affiché pour la classe
        /// </summary>
        /// <returns>h:m:s</returns>
        public override string ToString()
        {
            return (jours + 1) + (((jours + 1) == 1) ? "er" : "eme") + " jour de mission, " + ((heure.ToString().Length == 1) ? "0" : "") + heure + ":" + ((minute.ToString().Length == 1) ? "0" : "") + minute + ":" + ((seconde.ToString().Length == 1) ? "0" : "") + seconde;
        }
    }
}
