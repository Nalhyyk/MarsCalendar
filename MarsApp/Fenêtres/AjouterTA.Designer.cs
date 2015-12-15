namespace MarsApp
{
    partial class AjouterTA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activiteRadio = new System.Windows.Forms.RadioButton();
            this.domaineRadio = new System.Windows.Forms.RadioButton();
            this.listBoxDoms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomTA = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.couleur = new System.Windows.Forms.Panel();
            this.Reduire = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.groupBox1.Controls.Add(this.activiteRadio);
            this.groupBox1.Controls.Add(this.domaineRadio);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(53, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(292, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // activiteRadio
            // 
            this.activiteRadio.AutoSize = true;
            this.activiteRadio.Location = new System.Drawing.Point(159, 23);
            this.activiteRadio.Margin = new System.Windows.Forms.Padding(4);
            this.activiteRadio.Name = "activiteRadio";
            this.activiteRadio.Size = new System.Drawing.Size(78, 23);
            this.activiteRadio.TabIndex = 4;
            this.activiteRadio.Text = "Activité";
            this.activiteRadio.UseVisualStyleBackColor = true;
            // 
            // domaineRadio
            // 
            this.domaineRadio.AutoSize = true;
            this.domaineRadio.Checked = true;
            this.domaineRadio.Location = new System.Drawing.Point(65, 23);
            this.domaineRadio.Margin = new System.Windows.Forms.Padding(4);
            this.domaineRadio.Name = "domaineRadio";
            this.domaineRadio.Size = new System.Drawing.Size(86, 23);
            this.domaineRadio.TabIndex = 3;
            this.domaineRadio.TabStop = true;
            this.domaineRadio.Text = "Domaine";
            this.domaineRadio.UseVisualStyleBackColor = true;
            this.domaineRadio.CheckedChanged += new System.EventHandler(this.type_CheckedChanged);
            // 
            // listBoxDoms
            // 
            this.listBoxDoms.Enabled = false;
            this.listBoxDoms.FormattingEnabled = true;
            this.listBoxDoms.ItemHeight = 16;
            this.listBoxDoms.Location = new System.Drawing.Point(153, 124);
            this.listBoxDoms.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDoms.Name = "listBoxDoms";
            this.listBoxDoms.Size = new System.Drawing.Size(192, 52);
            this.listBoxDoms.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(45, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom :";
            // 
            // nomTA
            // 
            this.nomTA.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTA.ForeColor = System.Drawing.Color.Black;
            this.nomTA.Location = new System.Drawing.Point(101, 188);
            this.nomTA.Margin = new System.Windows.Forms.Padding(4);
            this.nomTA.Name = "nomTA";
            this.nomTA.Size = new System.Drawing.Size(245, 25);
            this.nomTA.TabIndex = 9;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.Highlight;
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ok.Location = new System.Drawing.Point(48, 237);
            this.ok.Margin = new System.Windows.Forms.Padding(4);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 28);
            this.ok.TabIndex = 11;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.SystemColors.Highlight;
            this.annuler.FlatAppearance.BorderSize = 0;
            this.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuler.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.annuler.Location = new System.Drawing.Point(246, 237);
            this.annuler.Margin = new System.Windows.Forms.Padding(4);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(100, 28);
            this.annuler.TabIndex = 10;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // couleur
            // 
            this.couleur.BackColor = System.Drawing.Color.Gray;
            this.couleur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.couleur.Location = new System.Drawing.Point(73, 134);
            this.couleur.Margin = new System.Windows.Forms.Padding(4);
            this.couleur.Name = "couleur";
            this.couleur.Size = new System.Drawing.Size(53, 26);
            this.couleur.TabIndex = 12;
            this.couleur.Click += new System.EventHandler(this.couleur_Click);
            // 
            // Reduire
            // 
            this.Reduire.AutoSize = true;
            this.Reduire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.Reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reduire.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Reduire.Location = new System.Drawing.Point(307, 3);
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
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.X.Location = new System.Drawing.Point(345, 3);
            this.X.MaximumSize = new System.Drawing.Size(30, 30);
            this.X.MinimumSize = new System.Drawing.Size(30, 30);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(30, 30);
            this.X.TabIndex = 13;
            this.X.Text = "X";
            this.X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.X.Click += new System.EventHandler(this.X_Click);
            this.X.MouseLeave += new System.EventHandler(this.X_MouseLeave);
            this.X.MouseHover += new System.EventHandler(this.X_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Reduire);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 39);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(109, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ajout type d\'activité";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarsApp.Properties.Resources.icon_50px_Mars;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // AjouterTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(387, 298);
            this.Controls.Add(this.X);
            this.Controls.Add(this.couleur);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.nomTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDoms);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AjouterTA";
            this.Text = "AjouterTA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton activiteRadio;
        private System.Windows.Forms.RadioButton domaineRadio;
        private System.Windows.Forms.ListBox listBoxDoms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomTA;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel couleur;
        private System.Windows.Forms.Label Reduire;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}