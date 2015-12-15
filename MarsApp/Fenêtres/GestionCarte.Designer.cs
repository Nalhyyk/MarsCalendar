namespace MarsApp
{
    partial class GestionCarte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCarte));
            this.map = new System.Windows.Forms.PictureBox();
            this.activitesExterieures = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Image = global::MarsApp.Properties.Resources.Carte;
            this.map.Location = new System.Drawing.Point(16, 15);
            this.map.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(427, 738);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            this.map.Paint += new System.Windows.Forms.PaintEventHandler(this.map_Paint);
            // 
            // activitesExterieures
            // 
            this.activitesExterieures.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.activitesExterieures.Location = new System.Drawing.Point(452, 16);
            this.activitesExterieures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activitesExterieures.Name = "activitesExterieures";
            this.activitesExterieures.Size = new System.Drawing.Size(252, 736);
            this.activitesExterieures.TabIndex = 1;
            this.activitesExterieures.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.activitesExterieures_AfterSelect);
            // 
            // GestionCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(736, 764);
            this.Controls.Add(this.activitesExterieures);
            this.Controls.Add(this.map);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "GestionCarte";
            this.Text = "Gestion de la carte";
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.TreeView activitesExterieures;
    }
}