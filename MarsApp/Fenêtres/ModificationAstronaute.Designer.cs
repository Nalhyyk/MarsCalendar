﻿namespace MarsApp
{
    partial class ModificationAstronaute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificationAstronaute));
            this.age = new System.Windows.Forms.NumericUpDown();
            this.annuler = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(99, 79);
            this.age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(281, 22);
            this.age.TabIndex = 13;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(280, 114);
            this.annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(100, 28);
            this.annuler.TabIndex = 15;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(172, 114);
            this.modifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(100, 28);
            this.modifier.TabIndex = 14;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(99, 44);
            this.prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(280, 22);
            this.prenom.TabIndex = 12;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(99, 14);
            this.nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(280, 22);
            this.nom.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Âge :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom :";
            // 
            // ModificationAstronaute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 156);
            this.Controls.Add(this.age);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ModificationAstronaute";
            this.Text = "Modification de l\'astronaute";
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}