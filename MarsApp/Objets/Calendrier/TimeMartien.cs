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
            this.jours = jours;
            this.heure = heure;
            this.minute = minute;
            this.seconde = seconde;
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
            while (this.seconde > 59)
            {
                this.seconde -= 60;
                ++this.minute;
            }

            // On veut obtenir des minutes comprises entre 0 et 59
            while (this.minute > 59)
            {
                this.minute -= 60;
                ++this.heure;
            }

            /* On veut obtenir des heures comprises entre 0 et 24, la limite étant 24h40
             * (au delà de 24h40, on retire 24h et 40m)
             */
            while (this.heure > 24 || (this.heure == 24 && this.minute > 39))
            {
                this.heure -= 24;
                this.minute -= 40;
                this.jours += 1;
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

                while (this.heure < 0)
                {
                    this.heure += 25;
                    this.minute -= 20;
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

        /// <summary>
        /// Permet de convertir un DateTime en TimeMartien
        /// </summary>
        /// <param name="dt">Un DateTime</param>
        /// <returns>Le TImeMartien correspondant au DateTime</returns>
        public static TimeMartien convertirDateTime(DateTime dt)
        {
            TimeSpan ts = new TimeSpan(dt.Ticks);
            TimeMartien tm = new TimeMartien(0, 0, 0, (int)Math.Truncate(ts.TotalSeconds));

            return tm;
        }

        /// <summary>
        /// Permet de calculer le nombre de jours passés depuis le DateTime spécifié (en temps martien)
        /// </summary>
        /// <param name="dateDepart">Un DateTime</param>
        /// <returns>Le nombre de jours écoulés depuis la date spécifiée, en temps martien</returns>
        public static TimeMartien calculerJours(DateTime dateDepart)
        {
            DateTime dt = DateTime.Now;

            long ticks = dt.Ticks - dateDepart.Ticks;
            TimeSpan ts = new TimeSpan(ticks);

            TimeMartien tm = new TimeMartien(0, 0, 0, (int) Math.Truncate(ts.TotalSeconds));

            return tm;
        }

        #region Génération XML
        public void genererXML(XmlDocument xmlDoc, XmlNode heureMartienne)
        {
            XmlNode jours = xmlDoc.CreateElement("Jours");
            heureMartienne.AppendChild(jours);
            jours.InnerText = this.jours.ToString();

            XmlNode heures = xmlDoc.CreateElement("Heures");
            heureMartienne.AppendChild(heures);
            heures.InnerText = this.heure.ToString();

            XmlNode minutes = xmlDoc.CreateElement("Minutes");
            heureMartienne.AppendChild(minutes);
            minutes.InnerText = this.minute.ToString();

            XmlNode secondes = xmlDoc.CreateElement("Secondes");
            heureMartienne.AppendChild(secondes);
            secondes.InnerText = this.seconde.ToString();
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
        #endregion

        /// <summary>
        /// Texte affiché pour la classe
        /// </summary>
        /// <returns>h:m:s</returns>
        public override string ToString()
        {
            return ++jours + ((jours == 1) ? "er" : "eme") + " jour de mission, " + ((heure.ToString().Length == 1) ? "0" : "") + heure + ":" + ((minute.ToString().Length == 1) ? "0" : "") + minute + ":" + ((seconde.ToString().Length == 1) ? "0" : "") + seconde;
        }
    }
}
