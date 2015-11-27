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
    public partial class MoteurRecherche : BaseFenetre
    {
        List<Journee> joursPasses;
        List<Activite> activitesPassees;
        Dictionary<int, Journee> journeesMission;

        public MoteurRecherche(Dictionary<int, Journee> journeesMission)
        {
            InitializeComponent();

            activitesPassees = new List<Activite>();
            joursPasses = new List<Journee>();
            this.journeesMission = journeesMission;

            for (int i = 1; i <= 500; ++i)
                if (journeesMission[i].getEtat().Equals(Constantes.ETAT_PASSE) || journeesMission[i].getEtat().Equals(Constantes.ETAT_ENCOURS))
                    joursPasses.Add(journeesMission[i]);


            chercherDansActivitesPassees(1, 500, "", "");
        }

        private void chercherDansActivitesPassees(int jourDebut, int jourFin, String nom, String description)
        {
            activitesPassees.Clear();
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

        private void touche_KeyUp(object sender, KeyEventArgs e)
        {
            chercherDansActivitesPassees((int) jourDebut.Value, (int) jourFin.Value, nomAct.Text, description.Text);
        }

        private void jour_valueChanged(object sender, EventArgs e)
        {
            chercherDansActivitesPassees((int)jourDebut.Value, (int)jourFin.Value, nomAct.Text, description.Text);
        }

        private void treeView1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!((TreeView)sender).SelectedNode.Text.StartsWith("Journée"))
            {
                InfoActivite ia = new InfoActivite((Activite)((TreeView)sender).SelectedNode.Tag);
                ia.Show();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!((TreeView)sender).SelectedNode.Text.StartsWith("Journée"))
            {
                InfoActivite ia = new InfoActivite((Activite)((TreeView)sender).SelectedNode.Tag);
                ia.Show();
            }
        }
    }
}
