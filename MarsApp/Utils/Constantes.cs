using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsApp
{
    /// <summary>
    /// Gestion des constantes du programme
    /// </summary>
    public class Constantes
    {
        public const int NB_JOUR_MISSION = 500;

        public const int LIMITE_RAPPORT_JOURNEE = 1000;
        public const int LIMITE_DESCRIPTION_ACTIVITE = 400;

        public const int LARGEUR_CARTE = 1095;
        public const int HAUTEUR_CARTE = 2053;
        public const int POSITION_BASE_X = 700;
        public const int POSITION_BASE_Y = 1000;
        public const double RAPPORT_CARTES = 3.421875;

        public const String ETAT_PASSE = "Passé";
        public const String ETAT_ENCOURS = "EnCours";
        public const String ETAT_FUTUR = "Futur";
    }
}
