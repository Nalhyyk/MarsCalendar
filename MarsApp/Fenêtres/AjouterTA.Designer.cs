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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activiteRadio);
            this.groupBox1.Controls.Add(this.domaineRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // activiteRadio
            // 
            this.activiteRadio.AutoSize = true;
            this.activiteRadio.Location = new System.Drawing.Point(119, 19);
            this.activiteRadio.Name = "activiteRadio";
            this.activiteRadio.Size = new System.Drawing.Size(60, 17);
            this.activiteRadio.TabIndex = 4;
            this.activiteRadio.Text = "Activité";
            this.activiteRadio.UseVisualStyleBackColor = true;
            // 
            // domaineRadio
            // 
            this.domaineRadio.AutoSize = true;
            this.domaineRadio.Checked = true;
            this.domaineRadio.Location = new System.Drawing.Point(49, 19);
            this.domaineRadio.Name = "domaineRadio";
            this.domaineRadio.Size = new System.Drawing.Size(67, 17);
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
            this.listBoxDoms.Location = new System.Drawing.Point(90, 65);
            this.listBoxDoms.Name = "listBoxDoms";
            this.listBoxDoms.Size = new System.Drawing.Size(145, 43);
            this.listBoxDoms.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom :";
            // 
            // nomTA
            // 
            this.nomTA.Location = new System.Drawing.Point(50, 119);
            this.nomTA.Name = "nomTA";
            this.nomTA.Size = new System.Drawing.Size(185, 20);
            this.nomTA.TabIndex = 9;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(79, 160);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 11;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(160, 160);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 10;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // couleur
            // 
            this.couleur.BackColor = System.Drawing.Color.Gray;
            this.couleur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.couleur.Location = new System.Drawing.Point(30, 74);
            this.couleur.Name = "couleur";
            this.couleur.Size = new System.Drawing.Size(41, 22);
            this.couleur.TabIndex = 12;
            this.couleur.Click += new System.EventHandler(this.couleur_Click);
            // 
            // AjouterTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 195);
            this.Controls.Add(this.couleur);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.nomTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDoms);
            this.Controls.Add(this.groupBox1);
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

    }
}