using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Activité d'expérience se passant en extérieur
    /// </summary>
    public class ExperienceExterieure : Activite
    {
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="nom">Nom de l'Activite</param>
        /// <param name="description">Description de l'Activite</param>
        /// <param name="debut">Date de début de l'Activite</param>
        /// <param name="fin">Date de fin de l'Activite</param>
        /// <param name="lieu">Lieu de l'Activite</param>
        public ExperienceExterieure(String nom, String description, TimeMartien debut, TimeMartien fin, Lieu lieu) 
            : base(nom, description, debut, fin, lieu)
        {

        }
    }
}
