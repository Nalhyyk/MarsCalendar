using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarsApp
{
    /// <summary>
    /// Interface permettant de créer un nouvel astronaute
    /// </summary>
    public partial class NouveauAstronaute : BaseFenetre
    {
        private List<Astronaute> astronautes;
        private ListBox astroList;
        private int numJour;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="astronautes">Liste des astronautes</param>
        /// <param name="astroList">ListBox contenant les astronautes</param>
        /// <param name="numJour">Numéro du jour actuel</param>
        public NouveauAstronaute(List<Astronaute> astronautes, ListBox astroList, int numJour)
        {
            InitializeComponent();

            this.astronautes = astronautes;
            this.astroList = astroList;
            this.numJour = numJour;
        }
        #endregion

        #region Evènements
        /// <summary>
        /// Permet d'annuler l'ajout
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void annuler_Click(object sender, EventArgs e)
        {
            fermerFenetre();
        }

        /// <summary>
        /// Permet de procéder à l'ajout de l'astronaute
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void ajouter_Click(object sender, EventArgs e)
        {
            Astronaute a = new Astronaute(nom.Text, prenom.Text, Convert.ToInt32(age.Value));
            a.creerEdT(numJour);
            astronautes.Add(a);
            astroList.Items.Add(a);
            fermerFenetre();
        }
        #endregion
    }
}
