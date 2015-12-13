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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificationActivite));
            this.treeView = new System.Windows.Forms.TreeView();
            this.annuler = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.interieurRadio = new System.Windows.Forms.RadioButton();
            this.exterieurRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activiteExterieureGB = new System.Windows.Forms.GroupBox();
            this.explorationRadio = new System.Windows.Forms.RadioButton();
            this.experienceRadio = new System.Windows.Forms.RadioButton();
            this.temps = new System.Windows.Forms.GroupBox();
            this.errDuree = new System.Windows.Forms.Label();
            this.finMinute = new System.Windows.Forms.NumericUpDown();
            this.debutMinute = new System.Windows.Forms.NumericUpDown();
            this.finHeure = new System.Windows.Forms.NumericUpDown();
            this.debutHeure = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.lieuGB = new System.Windows.Forms.GroupBox();
            this.lieuTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transportGB = new System.Windows.Forms.GroupBox();
            this.vehiculeRadio = new System.Windows.Forms.RadioButton();
            this.scaphandreRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.activiteExterieureGB.SuspendLayout();
            this.temps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutHeure)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.lieuGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.transportGB.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.interieurRadio);
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
            this.temps.Controls.Add(this.errDuree);
            this.temps.Controls.Add(this.finMinute);
            this.temps.Controls.Add(this.debutMinute);
            this.temps.Controls.Add(this.finHeure);
            this.temps.Controls.Add(this.debutHeure);
            this.temps.Controls.Add(this.label2);
            this.temps.Controls.Add(this.label1);
            this.temps.Location = new System.Drawing.Point(250, 122);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(336, 127);
            this.temps.TabIndex = 7;
            this.temps.TabStop = false;
            this.temps.Text = "Durée activité";
            // 
            // errDuree
            // 
            this.errDuree.AutoSize = true;
            this.errDuree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errDuree.Location = new System.Drawing.Point(7, 108);
            this.errDuree.Name = "errDuree";
            this.errDuree.Size = new System.Drawing.Size(253, 13);
            this.errDuree.TabIndex = 10;
            this.errDuree.Text = "La durée de l\'activité doit être d\'au moins 10 minutes";
            this.errDuree.Visible = false;
            // 
            // finMinute
            // 
            this.finMinute.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.finMinute.Location = new System.Drawing.Point(186, 73);
            this.finMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.finMinute.Name = "finMinute";
            this.finMinute.Size = new System.Drawing.Size(80, 20);
            this.finMinute.TabIndex = 9;
            this.finMinute.ValueChanged += new System.EventHandler(this.duree_ValueChanged);
            // 
            // debutMinute
            // 
            this.debutMinute.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.debutMinute.Location = new System.Drawing.Point(186, 33);
            this.debutMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.debutMinute.Name = "debutMinute";
            this.debutMinute.Size = new System.Drawing.Size(80, 20);
            this.debutMinute.TabIndex = 8;
            this.debutMinute.ValueChanged += new System.EventHandler(this.duree_ValueChanged);
            // 
            // finHeure
            // 
            this.finHeure.Location = new System.Drawing.Point(100, 73);
            this.finHeure.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.finHeure.Name = "finHeure";
            this.finHeure.Size = new System.Drawing.Size(80, 20);
            this.finHeure.TabIndex = 7;
            this.finHeure.ValueChanged += new System.EventHandler(this.duree_ValueChanged);
            // 
            // debutHeure
            // 
            this.debutHeure.Location = new System.Drawing.Point(100, 33);
            this.debutHeure.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.debutHeure.Name = "debutHeure";
            this.debutHeure.Size = new System.Drawing.Size(80, 20);
            this.debutHeure.TabIndex = 6;
            this.debutHeure.ValueChanged += new System.EventHandler(this.duree_ValueChanged);
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
            this.groupBox2.Location = new System.Drawing.Point(251, 353);
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
            // lieuGB
            // 
            this.lieuGB.Controls.Add(this.lieuTB);
            this.lieuGB.Controls.Add(this.label3);
            this.lieuGB.Controls.Add(this.pictureBox1);
            this.lieuGB.Enabled = false;
            this.lieuGB.Location = new System.Drawing.Point(251, 266);
            this.lieuGB.Name = "lieuGB";
            this.lieuGB.Size = new System.Drawing.Size(336, 72);
            this.lieuGB.TabIndex = 9;
            this.lieuGB.TabStop = false;
            this.lieuGB.Text = "Lieu";
            // 
            // lieuTB
            // 
            this.lieuTB.Location = new System.Drawing.Point(99, 30);
            this.lieuTB.Name = "lieuTB";
            this.lieuTB.Size = new System.Drawing.Size(172, 20);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarsApp.Properties.Resources.map50px;
            this.pictureBox1.Location = new System.Drawing.Point(277, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // transportGB
            // 
            this.transportGB.Controls.Add(this.vehiculeRadio);
            this.transportGB.Controls.Add(this.scaphandreRadio);
            this.transportGB.Enabled = false;
            this.transportGB.Location = new System.Drawing.Point(409, 66);
            this.transportGB.Name = "transportGB";
            this.transportGB.Size = new System.Drawing.Size(178, 47);
            this.transportGB.TabIndex = 7;
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
            // ModificationActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 562);
            this.Controls.Add(this.transportGB);
            this.Controls.Add(this.lieuGB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.activiteExterieureGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.treeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificationActivite";
            this.Text = "Modification de l\'activité";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.activiteExterieureGB.ResumeLayout(false);
            this.activiteExterieureGB.PerformLayout();
            this.temps.ResumeLayout(false);
            this.temps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutHeure)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.lieuGB.ResumeLayout(false);
            this.lieuGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.transportGB.ResumeLayout(false);
            this.transportGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.RadioButton interieurRadio;
        private System.Windows.Forms.RadioButton exterieurRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox activiteExterieureGB;
        private System.Windows.Forms.RadioButton explorationRadio;
        private System.Windows.Forms.RadioButton experienceRadio;
        private System.Windows.Forms.GroupBox temps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.GroupBox lieuGB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lieuTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox transportGB;
        private System.Windows.Forms.RadioButton vehiculeRadio;
        private System.Windows.Forms.RadioButton scaphandreRadio;
        private System.Windows.Forms.NumericUpDown finMinute;
        private System.Windows.Forms.NumericUpDown debutMinute;
        private System.Windows.Forms.NumericUpDown finHeure;
        private System.Windows.Forms.NumericUpDown debutHeure;
        private System.Windows.Forms.Label errDuree;
    }
}