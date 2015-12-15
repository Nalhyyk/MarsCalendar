using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MarsApp
{
    /// <summary>
    /// Interface du moteur de recherche des activités passées
    /// </summary>
    public partial class MoteurRecherche : BaseFenetre
    {
        List<Journee> joursPasses;
        List<Activite> activitesPassees;
        Dictionary<int, Journee> journeesMission;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #region Constructeurs
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="journeesMission">Les journées de la mission</param>
        public MoteurRecherche(Dictionary<int, Journee> journeesMission, int numJour)
        {
            InitializeComponent();

            activitesPassees = new List<Activite>();
            joursPasses = new List<Journee>();
            this.journeesMission = journeesMission;
            this.jourFin.Value = numJour;

            for (int i = 1; i <= numJour; ++i)
                if (journeesMission[i].getEtat().Equals(Constantes.ETAT_PASSE) || journeesMission[i].getEtat().Equals(Constantes.ETAT_ENCOURS))
                    joursPasses.Add(journeesMission[i]);


            chercherDansActivitesPassees(1, numJour, "", "");
        }
        #endregion

        /// <summary>
        /// Permet de chercher les activitées passées en fonction de certaines informations
        /// </summary>
        /// <param name="jourDebut">Journée de début</param>
        /// <param name="jourFin">Journée de fin</param>
        /// <param name="nom">Nom de l'activité</param>
        /// <param name="description">Description de l'activité</param>
        private void chercherDansActivitesPassees(int jourDebut, int jourFin, String nom, String description)
        {
            if (activitesPassees.Count != 0)
                activitesPassees.Clear();

            if (treeView1.Nodes.Count != 0)
                treeView1.Nodes.Clear();

            foreach (Journee j in joursPasses)
            {
                if (j.getNumero() >= jourDebut && j.getNumero() <= jourFin)
                {
                    TreeNode tn = new TreeNode("Journée " + j.getNumero());

                    bool insere = false;

                    foreach (Activite a in j.getActivites())
                        if (a.getEtat().Equals(Constantes.ETAT_PASSE) && a.getDescription().Contains(description) && a.getNom().Contains(nom))
                        {
                            if (!insere)
                            {
                                treeView1.Nodes.Add(tn);
                                insere = true;
                            }

                            activitesPassees.Add(a);

                            TreeNode tnn = new TreeNode(a.getNom() + " -> " + a.getHeureDebut().affichageSansJour() + " à " + a.getHeureFin().affichageSansJour());
                            tn.Nodes.Add(tnn);
                            tnn.Tag = a;
                        }
                }
            }

            Refresh();
        }

        #region Evènements
        /// <summary>
        /// Permet de rechercher les activités
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènements</param>
        private void touche_KeyUp(object sender, KeyEventArgs e)
        {
            chercherDansActivitesPassees((int)jourDebut.Value, (int)jourFin.Value, nomAct.Text, description.Text);
        }

        /// <summary>
        /// Permet de rechercher les activités
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènements</param>
        private void jour_valueChanged(object sender, EventArgs e)
        {
            chercherDansActivitesPassees((int)jourDebut.Value, (int)jourFin.Value, nomAct.Text, description.Text);
        }

        /// <summary>
        /// Permet d'afficher les informations de l'activité sélectionnée
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènements</param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!((TreeView)sender).SelectedNode.Text.StartsWith("Journée"))
            {
                InfoActivite ia = new InfoActivite((Activite)((TreeView)sender).SelectedNode.Tag);
                ia.Show();
            }
        }

        /// <summary>
        /// Permet de réduire la fenêtre en cours
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void Reduire_Click(object sender, EventArgs e)
        {
            reduireFenetre();
        }

        /// <summary>
        /// Permet de fermer la fenêtre en cours
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void X_Click(object sender, EventArgs e)
        {
            fermerFenetre();
        }

        /// <summary>
        /// Permet de déplacer la fenêtre par la zone du haut
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        /// <summary>
        /// Permet de modifier la couleur du bouton lors du survol
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void Reduire_MouseHover(object sender, EventArgs e)
        {
            Reduire.BackColor = System.Drawing.Color.FromArgb(0, 148, 241);
        }

        /// <summary>
        /// Permet de revenir à l'état de base après le survol
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void Reduire_MouseLeave(object sender, EventArgs e)
        {
            Reduire.BackColor = System.Drawing.Color.FromArgb(17, 19, 23);
        }

        /// <summary>
        /// Permet de modifier la couleur du bouton lors du survol
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void X_MouseHover(object sender, EventArgs e)
        {
            X.BackColor = System.Drawing.Color.FromArgb(0, 148, 241);
        }

        /// <summary>
        /// Permet de revenir à l'état de base après le survol
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void X_MouseLeave(object sender, EventArgs e)
        {
            X.BackColor = System.Drawing.Color.FromArgb(17, 19, 23);
        }
        #endregion
    }
}