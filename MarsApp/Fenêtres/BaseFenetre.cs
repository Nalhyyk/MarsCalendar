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
    /// Classe mère de tous les WForm
    /// </summary>
    public partial class BaseFenetre : Form
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public BaseFenetre()
        {
            centrerFenetre();
        }

        /// <summary>
        /// Permet de centrer la fenêtre sur l'écran
        /// </summary>
        public void centrerFenetre()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Permet de fermer la fenêtre
        /// </summary>
        public void fermerFenetre()
        {
            this.Dispose();
        }

        /// <summary>
        /// Permet de fermer l'application
        /// </summary>
        public void fermerApplication()
        {
            Application.Exit();
        }

        /// <summary>
        /// Permet de cacher la fenêtre
        /// </summary>
        public void cacherFenetre()
        {
            this.Hide();
        }
    }
}
