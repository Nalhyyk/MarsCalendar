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
    /// Interface affichant la carte et les activités extérieures
    /// </summary>
    public partial class GestionCarte : BaseFenetre
    {
        private List<Lieu> lieuxADessiner;
        private Dictionary<int, Journee> journees;
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
        /// <param name="journees">Liste des journées de la mission</param>
        public GestionCarte(Dictionary<int, Journee> journees)
        {
            InitializeComponent();

            this.journees = journees;

            lieuxADessiner = new List<Lieu>();

            TreeNode t = new TreeNode("Tout afficher");

            activitesExterieures.Nodes.Add(t);
            activitesExterieures.SelectedNode = t;

            for (int i = 1; i <= journees.Count(); ++i)
            {
                if (journees[i].isJourneeExterieure())
                {
                    TreeNode tn = new TreeNode("Journée " + i);
                    activitesExterieures.Nodes.Add(tn);

                    foreach (Activite a in journees[i].getActivites())
                        if (a.isActiviteExterieure())
                        {
                            TreeNode tnn = new TreeNode(a.getNom() + " - " + a.getHeureDebut().getHeures() + "h -> " + a.getHeureFin().getHeures() + "h");
                            tnn.Tag = a;
                            tn.Nodes.Add(tnn);

                            lieuxADessiner.Add(a.getLieu());
                        }
                }
            }

            this.Refresh();
        }
        #endregion

        /// <summary>
        /// Stocke dans une liste toutes les activités extérieures
        /// </summary>
        private void toutesLesActivitesExterieures()
        {
            lieuxADessiner.Clear();
            for (int i = 1; i <= journees.Count(); ++i)
                if (journees[i].isJourneeExterieure())
                    foreach (Activite a in journees[i].getActivites())
                        if (a.isActiviteExterieure())
                            lieuxADessiner.Add(a.getLieu());
        }

        /// <summary>
        /// Stocke dans une liste toutes les activités extérieures d'une journée
        /// </summary>
        /// <param name="journee">Le numéro de la journée</param>
        private void toutesLesActivitesExterieuresJournee(int journee)
        {
            lieuxADessiner.Clear();
            if (journees[journee].isJourneeExterieure())
                foreach (Activite a in journees[journee].getActivites())
                    if (a.isActiviteExterieure())
                        lieuxADessiner.Add(a.getLieu());
        }

        /// <summary>
        /// Stocke dans une liste l'activité si elle se trouve en extérieur
        /// </summary>
        /// <param name="a">Une activité</param>
        private void activiteExterieure(Activite a)
        {
            lieuxADessiner.Clear();
            if (a.isActiviteExterieure())
                lieuxADessiner.Add(a.getLieu());
        }

        #region Evènements
        /// <summary>
        /// Permet de repeindre le composant
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènement</param>
        private void map_Paint(object sender, PaintEventArgs e)
        {
            foreach (Lieu l in lieuxADessiner)
                e.Graphics.FillEllipse(new SolidBrush(Color.DarkBlue), l.getXReduit(), l.getYReduit(), 15, 15);
        }

        /// <summary>
        /// Permet d'afficher les activités en fonction de l'option demandée (toutes, ...)
        /// </summary>
        /// <param name="sender">Objet source</param>
        /// <param name="e">Evènements</param>
        private void activitesExterieures_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selected = ((TreeView)sender).SelectedNode;

            if (selected.Text.StartsWith("Journée"))
            {
                String[] str = selected.Text.Split(' ');
                toutesLesActivitesExterieuresJournee(int.Parse(str[1]));
            }
            else if (selected.Text.StartsWith("Tout"))
                toutesLesActivitesExterieures();
            else
                activiteExterieure((Activite)selected.Tag);

            this.Refresh();
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
