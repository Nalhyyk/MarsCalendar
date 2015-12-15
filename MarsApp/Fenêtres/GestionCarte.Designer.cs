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
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Reduire = new System.Windows.Forms.Label();
            this.activitesExterieures = new System.Windows.Forms.TreeView();
            this.map = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Reduire);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 41);
            this.panel1.TabIndex = 175;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.X.Location = new System.Drawing.Point(694, 6);
            this.X.MaximumSize = new System.Drawing.Size(30, 30);
            this.X.MinimumSize = new System.Drawing.Size(30, 30);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(30, 30);
            this.X.TabIndex = 173;
            this.X.Text = "X";
            this.X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.X.Click += new System.EventHandler(this.X_Click);
            this.X.MouseLeave += new System.EventHandler(this.X_MouseLeave);
            this.X.MouseHover += new System.EventHandler(this.X_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(292, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Gestion de la carte";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarsApp.Properties.Resources.icon_50px_Mars;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Reduire
            // 
            this.Reduire.AutoSize = true;
            this.Reduire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.Reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reduire.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Reduire.Location = new System.Drawing.Point(654, 6);
            this.Reduire.MaximumSize = new System.Drawing.Size(30, 30);
            this.Reduire.MinimumSize = new System.Drawing.Size(30, 30);
            this.Reduire.Name = "Reduire";
            this.Reduire.Size = new System.Drawing.Size(30, 30);
            this.Reduire.TabIndex = 14;
            this.Reduire.Text = "-";
            this.Reduire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Reduire.Click += new System.EventHandler(this.Reduire_Click);
            this.Reduire.MouseLeave += new System.EventHandler(this.Reduire_MouseLeave);
            this.Reduire.MouseHover += new System.EventHandler(this.Reduire_MouseHover);
            // 
            // activitesExterieures
            // 
            this.activitesExterieures.Location = new System.Drawing.Point(455, 70);
            this.activitesExterieures.Margin = new System.Windows.Forms.Padding(4);
            this.activitesExterieures.Name = "activitesExterieures";
            this.activitesExterieures.Size = new System.Drawing.Size(252, 736);
            this.activitesExterieures.TabIndex = 1;
            this.activitesExterieures.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.activitesExterieures_AfterSelect);
            // 
            // map
            // 
            this.map.Image = global::MarsApp.Properties.Resources.Carte;
            this.map.Location = new System.Drawing.Point(19, 69);
            this.map.Margin = new System.Windows.Forms.Padding(4);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(427, 738);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            this.map.Paint += new System.Windows.Forms.PaintEventHandler(this.map_Paint);
            // 
            // GestionCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(736, 830);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.activitesExterieures);
            this.Controls.Add(this.map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GestionCarte";
            this.Text = "Gestion de la carte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.TreeView activitesExterieures;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Reduire;
    }
}