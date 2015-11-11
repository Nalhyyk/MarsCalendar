namespace MarsApp
{
    partial class InfoActivite
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
            this.transportGB = new System.Windows.Forms.GroupBox();
            this.vehiculeRadio = new System.Windows.Forms.RadioButton();
            this.scaphandreRadio = new System.Windows.Forms.RadioButton();
            this.lieuGB = new System.Windows.Forms.GroupBox();
            this.lieuTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.temps = new System.Windows.Forms.GroupBox();
            this.finHeure = new System.Windows.Forms.NumericUpDown();
            this.debutHeure = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activiteExterieureGB = new System.Windows.Forms.GroupBox();
            this.explorationRadio = new System.Windows.Forms.RadioButton();
            this.experienceRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exterieurRadio = new System.Windows.Forms.RadioButton();
            this.interieurRadio = new System.Windows.Forms.RadioButton();
            this.ok = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.transportGB.SuspendLayout();
            this.lieuGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.temps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutHeure)).BeginInit();
            this.activiteExterieureGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transportGB
            // 
            this.transportGB.Controls.Add(this.vehiculeRadio);
            this.transportGB.Controls.Add(this.scaphandreRadio);
            this.transportGB.Location = new System.Drawing.Point(408, 65);
            this.transportGB.Name = "transportGB";
            this.transportGB.Size = new System.Drawing.Size(178, 47);
            this.transportGB.TabIndex = 15;
            this.transportGB.TabStop = false;
            this.transportGB.Text = "Transport";
            // 
            // vehiculeRadio
            // 
            this.vehiculeRadio.AutoSize = true;
            this.vehiculeRadio.Location = new System.Drawing.Point(92, 19);
            this.vehiculeRadio.Name = "vehiculeRadio";
            this.vehiculeRadio.Size = new System.Drawing.Size(66, 17);
            this.vehiculeRadio.TabIndex = 1;
            this.vehiculeRadio.TabStop = true;
            this.vehiculeRadio.Text = "Véhicule";
            this.vehiculeRadio.UseVisualStyleBackColor = true;
            // 
            // scaphandreRadio
            // 
            this.scaphandreRadio.AutoSize = true;
            this.scaphandreRadio.Checked = true;
            this.scaphandreRadio.Location = new System.Drawing.Point(7, 19);
            this.scaphandreRadio.Name = "scaphandreRadio";
            this.scaphandreRadio.Size = new System.Drawing.Size(83, 17);
            this.scaphandreRadio.TabIndex = 0;
            this.scaphandreRadio.TabStop = true;
            this.scaphandreRadio.Text = "Scaphandre";
            this.scaphandreRadio.UseVisualStyleBackColor = true;
            // 
            // lieuGB
            // 
            this.lieuGB.Controls.Add(this.lieuTB);
            this.lieuGB.Controls.Add(this.label3);
            this.lieuGB.Location = new System.Drawing.Point(250, 265);
            this.lieuGB.Name = "lieuGB";
            this.lieuGB.Size = new System.Drawing.Size(336, 72);
            this.lieuGB.TabIndex = 18;
            this.lieuGB.TabStop = false;
            this.lieuGB.Text = "Lieu";
            // 
            // lieuTB
            // 
            this.lieuTB.Location = new System.Drawing.Point(99, 30);
            this.lieuTB.Name = "lieuTB";
            this.lieuTB.Size = new System.Drawing.Size(227, 20);
            this.lieuTB.TabIndex = 2;
            this.lieuTB.Text = "0;0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Coordonnées :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.descriptionTB);
            this.groupBox2.Location = new System.Drawing.Point(250, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 169);
            this.groupBox2.TabIndex = 17;
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
            // temps
            // 
            this.temps.Controls.Add(this.finHeure);
            this.temps.Controls.Add(this.debutHeure);
            this.temps.Controls.Add(this.label2);
            this.temps.Controls.Add(this.label1);
            this.temps.Location = new System.Drawing.Point(249, 121);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(336, 127);
            this.temps.TabIndex = 16;
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
            // activiteExterieureGB
            // 
            this.activiteExterieureGB.Controls.Add(this.explorationRadio);
            this.activiteExterieureGB.Controls.Add(this.experienceRadio);
            this.activiteExterieureGB.Location = new System.Drawing.Point(408, 12);
            this.activiteExterieureGB.Name = "activiteExterieureGB";
            this.activiteExterieureGB.Size = new System.Drawing.Size(178, 47);
            this.activiteExterieureGB.TabIndex = 14;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exterieurRadio);
            this.groupBox1.Controls.Add(this.interieurRadio);
            this.groupBox1.Location = new System.Drawing.Point(249, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 47);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localisation";
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
            // 
            // interieurRadio
            // 
            this.interieurRadio.AutoSize = true;
            this.interieurRadio.Checked = true;
            this.interieurRadio.Location = new System.Drawing.Point(8, 19);
            this.interieurRadio.Name = "interieurRadio";
            this.interieurRadio.Size = new System.Drawing.Size(63, 17);
            this.interieurRadio.TabIndex = 3;
            this.interieurRadio.TabStop = true;
            this.interieurRadio.Text = "Intérieur";
            this.interieurRadio.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(500, 538);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 12;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(231, 537);
            this.treeView.TabIndex = 10;
            // 
            // InfoActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 569);
            this.Controls.Add(this.transportGB);
            this.Controls.Add(this.lieuGB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.activiteExterieureGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.treeView);
            this.Name = "InfoActivite";
            this.Text = "InfoActivite";
            this.transportGB.ResumeLayout(false);
            this.transportGB.PerformLayout();
            this.lieuGB.ResumeLayout(false);
            this.lieuGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.temps.ResumeLayout(false);
            this.temps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutHeure)).EndInit();
            this.activiteExterieureGB.ResumeLayout(false);
            this.activiteExterieureGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox transportGB;
        private System.Windows.Forms.RadioButton vehiculeRadio;
        private System.Windows.Forms.RadioButton scaphandreRadio;
        private System.Windows.Forms.GroupBox lieuGB;
        private System.Windows.Forms.TextBox lieuTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.GroupBox temps;
        private System.Windows.Forms.NumericUpDown finHeure;
        private System.Windows.Forms.NumericUpDown debutHeure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox activiteExterieureGB;
        private System.Windows.Forms.RadioButton explorationRadio;
        private System.Windows.Forms.RadioButton experienceRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton exterieurRadio;
        private System.Windows.Forms.RadioButton interieurRadio;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TreeView treeView;

    }
}