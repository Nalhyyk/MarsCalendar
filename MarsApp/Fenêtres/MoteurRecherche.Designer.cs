namespace MarsApp
{
    partial class MoteurRecherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoteurRecherche));
            this.jourFin = new System.Windows.Forms.NumericUpDown();
            this.jourDebut = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.nomAct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Reduire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jourFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourDebut)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // jourFin
            // 
            this.jourFin.Location = new System.Drawing.Point(808, 134);
            this.jourFin.Margin = new System.Windows.Forms.Padding(4);
            this.jourFin.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.jourFin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jourFin.Name = "jourFin";
            this.jourFin.Size = new System.Drawing.Size(267, 25);
            this.jourFin.TabIndex = 8;
            this.jourFin.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.jourFin.ValueChanged += new System.EventHandler(this.jour_valueChanged);
            // 
            // jourDebut
            // 
            this.jourDebut.Location = new System.Drawing.Point(808, 90);
            this.jourDebut.Margin = new System.Windows.Forms.Padding(4);
            this.jourDebut.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.jourDebut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jourDebut.Name = "jourDebut";
            this.jourDebut.Size = new System.Drawing.Size(267, 25);
            this.jourDebut.TabIndex = 7;
            this.jourDebut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jourDebut.ValueChanged += new System.EventHandler(this.jour_valueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jour fin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jour début :";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(808, 242);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(265, 112);
            this.description.TabIndex = 4;
            this.description.KeyUp += new System.Windows.Forms.KeyEventHandler(this.touche_KeyUp);
            // 
            // nomAct
            // 
            this.nomAct.Location = new System.Drawing.Point(808, 185);
            this.nomAct.Margin = new System.Windows.Forms.Padding(4);
            this.nomAct.Name = "nomAct";
            this.nomAct.Size = new System.Drawing.Size(265, 25);
            this.nomAct.TabIndex = 3;
            this.nomAct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.touche_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de l\'activité :";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(17, 75);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(631, 282);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Reduire);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 41);
            this.panel1.TabIndex = 178;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.X.Location = new System.Drawing.Point(1053, 5);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(456, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Moteur de Recherche";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MarsApp.Properties.Resources.icon_50px_Mars;
            this.pictureBox2.Location = new System.Drawing.Point(7, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Reduire
            // 
            this.Reduire.AutoSize = true;
            this.Reduire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.Reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reduire.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Reduire.Location = new System.Drawing.Point(1013, 5);
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
            // MoteurRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1088, 377);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jourFin);
            this.Controls.Add(this.jourDebut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description);
            this.Controls.Add(this.nomAct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MoteurRecherche";
            this.Text = "Moteur de recherche";
            ((System.ComponentModel.ISupportInitialize)(this.jourFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourDebut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomAct;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown jourDebut;
        private System.Windows.Forms.NumericUpDown jourFin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Reduire;
    }
}