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
    /// Interface permettant d'ajouter de nouveaux domaines/types d'activité
    /// </summary>
    public partial class AjouterTA : BaseFenetre
    {
        private ModificationActivite ma;
        private int[] couleurTA;

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="ma">L'interface ModificationActivite à mettre à jour</param>
        public AjouterTA(ModificationActivite ma)
        {
            InitializeComponent();

            this.ma = ma;
            listBoxDoms.DataSource = CalendrierMission.domaines;
        }
        #endregion

        #region Evènements
        /// <summary>
        /// Permet d'activer/désactiver des contrôles en fonction des radios checkés
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void type_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoms.Enabled = !domaineRadio.Checked;
            couleur.Enabled = domaineRadio.Checked;
        }

        /// <summary>
        /// Permet de créer le domaine/type d'activité
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void ok_Click(object sender, EventArgs e)
        {
            String nom = nomTA.Text;

            if (!nom.Equals(""))
            {
                if (domaineRadio.Checked)
                    CalendrierMission.domaines.Add(new Domaine(nom, couleurTA));
                else
                    CalendrierMission.domaines.Find(elem => elem.getNom().Equals(listBoxDoms.SelectedItem.ToString())).ajouterActivite(new TypeActivite(nom));

                ma.remplirTreeView();

                fermerFenetre();
            }
        }

        /// <summary>
        /// Permet de choisir la couleur du domaine
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void couleur_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                couleurTA = new int[] { colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B };
                couleur.BackColor = colorDialog.Color;
            }
        }

        /// <summary>
        /// Permet d'annuler l'ajout
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
