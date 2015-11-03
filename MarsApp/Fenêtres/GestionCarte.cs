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
    public partial class GestionCarte : BaseFenetre
    {
        private List<Lieu> lieuxADessiner;
        private Dictionary<int, Journee> journees;

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

        private void toutesLesActivitesExterieures()
        {
            lieuxADessiner.Clear();
            for (int i = 1; i <= journees.Count(); ++i)
                if (journees[i].isJourneeExterieure())
                    foreach (Activite a in journees[i].getActivites())
                        if (a.isActiviteExterieure())
                            lieuxADessiner.Add(a.getLieu());
        }

        private void toutesLesActivitesExterieuresJournee(int journee)
        {
            lieuxADessiner.Clear();
            if (journees[journee].isJourneeExterieure())
                foreach (Activite a in journees[journee].getActivites())
                    if (a.isActiviteExterieure())
                        lieuxADessiner.Add(a.getLieu());
        }

        private void activiteExterieure(Activite a)
        {
            lieuxADessiner.Clear();
            if (a.isActiviteExterieure())
                lieuxADessiner.Add(a.getLieu());
        }

        private void map_Paint(object sender, PaintEventArgs e)
        {
            foreach (Lieu l in lieuxADessiner)
                e.Graphics.FillEllipse(new SolidBrush(Color.DarkBlue), l.getXReduit(), l.getYReduit(), 15, 15);
        }

        private void activitesExterieures_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selected = ((TreeView)sender).SelectedNode;

            if (selected.Text.StartsWith("Journée"))
            {
                String[] str = selected.Text.Split(' ');
                toutesLesActivitesExterieuresJournee(int.Parse(str[1]));
            }
            else if (selected.Text.StartsWith("Tout"))
            {
                toutesLesActivitesExterieures();
            }
            else
            {
                activiteExterieure((Activite)selected.Tag);
            }

            this.Refresh();
        }
    }
}
