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
    /// Interface permettant de modifier un astronaute
    /// </summary>
    public partial class ModificationAstronaute : BaseFenetre
    {
        private Astronaute aModifier;
        private List<Astronaute> astroList;
        private ListBox lb;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="a">L'astronaute à modifier</param>
        /// <param name="lb">La ListBox contenant les astronautes</param>
        /// <param name="astroList">La liste des astronautes</param>
        public ModificationAstronaute(Astronaute a, ListBox lb, List<Astronaute> astroList)
        {
            InitializeComponent();
            aModifier = a;
            this.astroList = astroList;
            this.lb = lb;

            nom.Text = aModifier.getNom();
            prenom.Text = aModifier.getPrenom();
            age.Value = aModifier.getAge();
        }
        #endregion

        #region Evènements
        /// <summary>
        /// Permet de procéder à la modification de l'astronaute
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void modifier_Click(object sender, EventArgs e)
        {
            aModifier.setNom(nom.Text);
            aModifier.setPrenom(prenom.Text);
            aModifier.setAge(Convert.ToInt32(age.Value));
            fermerFenetre();
            lb.DataSource = astroList;
            lb.Refresh();
        }

        /// <summary>
        /// Permet d'annuler la modification
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void annuler_Click(object sender, EventArgs e)
        {
            fermerFenetre();
        }
        #endregion
    }
}
