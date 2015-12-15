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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.groupBox1.Controls.Add(this.activiteRadio);
            this.groupBox1.Controls.Add(this.domaineRadio);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
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
            this.activiteRadio.Size = new System.Drawing.Size(74, 21);
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
            this.domaineRadio.Size = new System.Drawing.Size(85, 21);
            this.domaineRadio.TabIndex = 3;
            this.domaineRadio.TabStop = true;
            this.domaineRadio.Text = "Domaine";
            this.domaineRadio.UseVisualStyleBackColor = true;
            this.domaineRadio.CheckedChanged += new System.EventHandler(this.type_CheckedChanged);
            // 
            // listBoxDoms
            // 
            this.listBoxDoms.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxDoms.Enabled = false;
            this.listBoxDoms.FormattingEnabled = true;
            this.listBoxDoms.ItemHeight = 16;
            this.listBoxDoms.Location = new System.Drawing.Point(120, 80);
            this.listBoxDoms.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDoms.Name = "listBoxDoms";
            this.listBoxDoms.Size = new System.Drawing.Size(192, 52);
            this.listBoxDoms.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom :";
            // 
            // nomTA
            // 
            this.nomTA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomTA.Location = new System.Drawing.Point(67, 146);
            this.nomTA.Margin = new System.Windows.Forms.Padding(4);
            this.nomTA.Name = "nomTA";
            this.nomTA.Size = new System.Drawing.Size(245, 22);
            this.nomTA.TabIndex = 9;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.Highlight;
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ok.Location = new System.Drawing.Point(45, 197);
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
            this.annuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.annuler.Location = new System.Drawing.Point(185, 197);
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
            this.couleur.Location = new System.Drawing.Point(81, 80);
            this.couleur.Margin = new System.Windows.Forms.Padding(4);
            this.couleur.Name = "couleur";
            this.couleur.Size = new System.Drawing.Size(29, 26);
            this.couleur.TabIndex = 12;
            this.couleur.Click += new System.EventHandler(this.couleur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Couleur :";
            // 
            // AjouterTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(324, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.couleur);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.nomTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDoms);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AjouterTA";
            this.Text = "AjouterTA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
    }
}