namespace MarsApp
{
    partial class ModificationActivite
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.annuler = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.intérieurRadio = new System.Windows.Forms.RadioButton();
            this.exterieurRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activiteExterieureGB = new System.Windows.Forms.GroupBox();
            this.explorationRadio = new System.Windows.Forms.RadioButton();
            this.experienceRadio = new System.Windows.Forms.RadioButton();
            this.temps = new System.Windows.Forms.GroupBox();
            this.finHeure = new System.Windows.Forms.NumericUpDown();
            this.debutHeure = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.activiteExterieureGB.SuspendLayout();
            this.temps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutHeure)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.Location = new System.Drawing.Point(13, 13);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(231, 537);
            this.treeView.TabIndex = 0;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(518, 527);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 1;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(437, 527);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // intérieurRadio
            // 
            this.intérieurRadio.AutoSize = true;
            this.intérieurRadio.Checked = true;
            this.intérieurRadio.Location = new System.Drawing.Point(8, 19);
            this.intérieurRadio.Name = "intérieurRadio";
            this.intérieurRadio.Size = new System.Drawing.Size(63, 17);
            this.intérieurRadio.TabIndex = 3;
            this.intérieurRadio.TabStop = true;
            this.intérieurRadio.Text = "Intérieur";
            this.intérieurRadio.UseVisualStyleBackColor = true;
            // 
            // exterieurRadio
            // 
            this.exterieurRadio.AutoSize = true;
            this.exterieurRadio.Location = new System.Drawing.Point(78, 19);
            this.exterieurRadio.Name = "exterieurRadio";
            this.exterieurRadio.Size = new System.Drawing.Size(66, 17);
            this.exterieurRadio.TabIndex = 4;
            this.exterieurRadio.Text = "Extérieur";
            this.exterieurRadio.UseVisualStyleBackColor = true;
            this.exterieurRadio.CheckedChanged += new System.EventHandler(this.exterieurRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exterieurRadio);
            this.groupBox1.Controls.Add(this.intérieurRadio);
            this.groupBox1.Location = new System.Drawing.Point(250, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localisation";
            // 
            // activiteExterieureGB
            // 
            this.activiteExterieureGB.Controls.Add(this.explorationRadio);
            this.activiteExterieureGB.Controls.Add(this.experienceRadio);
            this.activiteExterieureGB.Enabled = false;
            this.activiteExterieureGB.Location = new System.Drawing.Point(409, 13);
            this.activiteExterieureGB.Name = "activiteExterieureGB";
            this.activiteExterieureGB.Size = new System.Drawing.Size(178, 47);
            this.activiteExterieureGB.TabIndex = 6;
            this.activiteExterieureGB.TabStop = false;
            this.activiteExterieureGB.Text = "Activité extérieure";
            // 
            // explorationRadio
            // 
            this.explorationRadio.AutoSize = true;
            this.explorationRadio.Location = new System.Drawing.Point(92, 19);
            this.explorationRadio.Name = "explorationRadio";
            this.explorationRadio.Size = new System.Drawing.Size(77, 17);
            this.explorationRadio.TabIndex = 1;
            this.explorationRadio.TabStop = true;
            this.explorationRadio.Text = "Exploration";
            this.explorationRadio.UseVisualStyleBackColor = true;
            // 
            // experienceRadio
            // 
            this.experienceRadio.AutoSize = true;
            this.experienceRadio.Checked = true;
            this.experienceRadio.Location = new System.Drawing.Point(7, 19);
            this.experienceRadio.Name = "experienceRadio";
            this.experienceRadio.Size = new System.Drawing.Size(78, 17);
            this.experienceRadio.TabIndex = 0;
            this.experienceRadio.TabStop = true;
            this.experienceRadio.Text = "Expérience";
            this.experienceRadio.UseVisualStyleBackColor = true;
            // 
            // temps
            // 
            this.temps.Controls.Add(this.finHeure);
            this.temps.Controls.Add(this.debutHeure);
            this.temps.Controls.Add(this.label2);
            this.temps.Controls.Add(this.label1);
            this.temps.Location = new System.Drawing.Point(250, 107);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(336, 127);
            this.temps.TabIndex = 7;
            this.temps.TabStop = false;
            this.temps.Text = "Durée activité";
            // 
            // finHeure
            // 
            this.finHeure.Location = new System.Drawing.Point(100, 71);
            this.finHeure.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.finHeure.Name = "finHeure";
            this.finHeure.Size = new System.Drawing.Size(228, 20);
            this.finHeure.TabIndex = 3;
            // 
            // debutHeure
            // 
            this.debutHeure.Location = new System.Drawing.Point(100, 31);
            this.debutHeure.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.debutHeure.Name = "debutHeure";
            this.debutHeure.Size = new System.Drawing.Size(228, 20);
            this.debutHeure.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heure de fin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heure de début :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.descriptionTB);
            this.groupBox2.Location = new System.Drawing.Point(251, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 169);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(9, 20);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(318, 143);
            this.descriptionTB.TabIndex = 0;
            // 
            // ModificationActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.activiteExterieureGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.treeView);
            this.Name = "ModificationActivite";
            this.Text = "ModificationActivite";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.activiteExterieureGB.ResumeLayout(false);
            this.activiteExterieureGB.PerformLayout();
            this.temps.ResumeLayout(false);
            this.temps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutHeure)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.RadioButton intérieurRadio;
        private System.Windows.Forms.RadioButton exterieurRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox activiteExterieureGB;
        private System.Windows.Forms.RadioButton explorationRadio;
        private System.Windows.Forms.RadioButton experienceRadio;
        private System.Windows.Forms.GroupBox temps;
        private System.Windows.Forms.NumericUpDown finHeure;
        private System.Windows.Forms.NumericUpDown debutHeure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox descriptionTB;
    }
}