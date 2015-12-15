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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoActivite));
            this.transportGB = new System.Windows.Forms.GroupBox();
            this.vehiculeRadio = new System.Windows.Forms.RadioButton();
            this.scaphandreRadio = new System.Windows.Forms.RadioButton();
            this.lieuGB = new System.Windows.Forms.GroupBox();
            this.lieuTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.temps = new System.Windows.Forms.GroupBox();
            this.finMinute = new System.Windows.Forms.NumericUpDown();
            this.debutMinute = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.finMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutHeure)).BeginInit();
            this.activiteExterieureGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transportGB
            // 
            this.transportGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.transportGB.Controls.Add(this.vehiculeRadio);
            this.transportGB.Controls.Add(this.scaphandreRadio);
            this.transportGB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.transportGB.Location = new System.Drawing.Point(544, 80);
            this.transportGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transportGB.Name = "transportGB";
            this.transportGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transportGB.Size = new System.Drawing.Size(237, 58);
            this.transportGB.TabIndex = 15;
            this.transportGB.TabStop = false;
            this.transportGB.Text = "Transport";
            // 
            // vehiculeRadio
            // 
            this.vehiculeRadio.AutoSize = true;
            this.vehiculeRadio.Location = new System.Drawing.Point(123, 23);
            this.vehiculeRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vehiculeRadio.Name = "vehiculeRadio";
            this.vehiculeRadio.Size = new System.Drawing.Size(83, 21);
            this.vehiculeRadio.TabIndex = 1;
            this.vehiculeRadio.TabStop = true;
            this.vehiculeRadio.Text = "Véhicule";
            this.vehiculeRadio.UseVisualStyleBackColor = true;
            // 
            // scaphandreRadio
            // 
            this.scaphandreRadio.AutoSize = true;
            this.scaphandreRadio.Checked = true;
            this.scaphandreRadio.Location = new System.Drawing.Point(9, 23);
            this.scaphandreRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scaphandreRadio.Name = "scaphandreRadio";
            this.scaphandreRadio.Size = new System.Drawing.Size(106, 21);
            this.scaphandreRadio.TabIndex = 0;
            this.scaphandreRadio.TabStop = true;
            this.scaphandreRadio.Text = "Scaphandre";
            this.scaphandreRadio.UseVisualStyleBackColor = true;
            // 
            // lieuGB
            // 
            this.lieuGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.lieuGB.Controls.Add(this.lieuTB);
            this.lieuGB.Controls.Add(this.label3);
            this.lieuGB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lieuGB.Location = new System.Drawing.Point(333, 326);
            this.lieuGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lieuGB.Name = "lieuGB";
            this.lieuGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lieuGB.Size = new System.Drawing.Size(448, 89);
            this.lieuGB.TabIndex = 18;
            this.lieuGB.TabStop = false;
            this.lieuGB.Text = "Lieu";
            // 
            // lieuTB
            // 
            this.lieuTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lieuTB.Location = new System.Drawing.Point(132, 37);
            this.lieuTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lieuTB.Name = "lieuTB";
            this.lieuTB.Size = new System.Drawing.Size(301, 22);
            this.lieuTB.TabIndex = 2;
            this.lieuTB.Text = "0;0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Coordonnées :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.groupBox2.Controls.Add(this.descriptionTB);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(333, 433);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(448, 208);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // descriptionTB
            // 
            this.descriptionTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.descriptionTB.Location = new System.Drawing.Point(12, 25);
            this.descriptionTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(423, 175);
            this.descriptionTB.TabIndex = 0;
            // 
            // temps
            // 
            this.temps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.temps.Controls.Add(this.finMinute);
            this.temps.Controls.Add(this.debutMinute);
            this.temps.Controls.Add(this.finHeure);
            this.temps.Controls.Add(this.debutHeure);
            this.temps.Controls.Add(this.label2);
            this.temps.Controls.Add(this.label1);
            this.temps.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.temps.Location = new System.Drawing.Point(332, 149);
            this.temps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temps.Name = "temps";
            this.temps.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temps.Size = new System.Drawing.Size(448, 156);
            this.temps.TabIndex = 16;
            this.temps.TabStop = false;
            this.temps.Text = "Durée activité";
            // 
            // finMinute
            // 
            this.finMinute.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.finMinute.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.finMinute.Location = new System.Drawing.Point(248, 87);
            this.finMinute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.finMinute.Name = "finMinute";
            this.finMinute.Size = new System.Drawing.Size(107, 22);
            this.finMinute.TabIndex = 5;
            this.finMinute.ValueChanged += new System.EventHandler(this.duree_ValueChanged);
            // 
            // debutMinute
            // 
            this.debutMinute.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.debutMinute.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.debutMinute.Location = new System.Drawing.Point(248, 38);
            this.debutMinute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debutMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.debutMinute.Name = "debutMinute";
            this.debutMinute.Size = new System.Drawing.Size(107, 22);
            this.debutMinute.TabIndex = 4;
            this.debutMinute.ValueChanged += new System.EventHandler(this.duree_ValueChanged);
            // 
            // finHeure
            // 
            this.finHeure.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.finHeure.Location = new System.Drawing.Point(133, 87);
            this.finHeure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finHeure.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.finHeure.Name = "finHeure";
            this.finHeure.Size = new System.Drawing.Size(107, 22);
            this.finHeure.TabIndex = 3;
            this.finHeure.ValueChanged += new System.EventHandler(this.duree_ValueChanged);
            // 
            // debutHeure
            // 
            this.debutHeure.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.debutHeure.Location = new System.Drawing.Point(133, 38);
            this.debutHeure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debutHeure.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.debutHeure.Name = "debutHeure";
            this.debutHeure.Size = new System.Drawing.Size(107, 22);
            this.debutHeure.TabIndex = 2;
            this.debutHeure.ValueChanged += new System.EventHandler(this.duree_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heure de fin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heure de début :";
            // 
            // activiteExterieureGB
            // 
            this.activiteExterieureGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.activiteExterieureGB.Controls.Add(this.explorationRadio);
            this.activiteExterieureGB.Controls.Add(this.experienceRadio);
            this.activiteExterieureGB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.activiteExterieureGB.Location = new System.Drawing.Point(544, 15);
            this.activiteExterieureGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activiteExterieureGB.Name = "activiteExterieureGB";
            this.activiteExterieureGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activiteExterieureGB.Size = new System.Drawing.Size(237, 58);
            this.activiteExterieureGB.TabIndex = 14;
            this.activiteExterieureGB.TabStop = false;
            this.activiteExterieureGB.Text = "Activité extérieure";
            // 
            // explorationRadio
            // 
            this.explorationRadio.AutoSize = true;
            this.explorationRadio.Location = new System.Drawing.Point(123, 23);
            this.explorationRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.explorationRadio.Name = "explorationRadio";
            this.explorationRadio.Size = new System.Drawing.Size(99, 21);
            this.explorationRadio.TabIndex = 1;
            this.explorationRadio.TabStop = true;
            this.explorationRadio.Text = "Exploration";
            this.explorationRadio.UseVisualStyleBackColor = true;
            // 
            // experienceRadio
            // 
            this.experienceRadio.AutoSize = true;
            this.experienceRadio.Checked = true;
            this.experienceRadio.Location = new System.Drawing.Point(9, 23);
            this.experienceRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.experienceRadio.Name = "experienceRadio";
            this.experienceRadio.Size = new System.Drawing.Size(99, 21);
            this.experienceRadio.TabIndex = 0;
            this.experienceRadio.TabStop = true;
            this.experienceRadio.Text = "Expérience";
            this.experienceRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.groupBox1.Controls.Add(this.exterieurRadio);
            this.groupBox1.Controls.Add(this.interieurRadio);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(332, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(204, 58);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localisation";
            // 
            // exterieurRadio
            // 
            this.exterieurRadio.AutoSize = true;
            this.exterieurRadio.Location = new System.Drawing.Point(104, 23);
            this.exterieurRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exterieurRadio.Name = "exterieurRadio";
            this.exterieurRadio.Size = new System.Drawing.Size(85, 21);
            this.exterieurRadio.TabIndex = 4;
            this.exterieurRadio.Text = "Extérieur";
            this.exterieurRadio.UseVisualStyleBackColor = true;
            // 
            // interieurRadio
            // 
            this.interieurRadio.AutoSize = true;
            this.interieurRadio.Checked = true;
            this.interieurRadio.Location = new System.Drawing.Point(11, 23);
            this.interieurRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.interieurRadio.Name = "interieurRadio";
            this.interieurRadio.Size = new System.Drawing.Size(81, 21);
            this.interieurRadio.TabIndex = 3;
            this.interieurRadio.TabStop = true;
            this.interieurRadio.Text = "Intérieur";
            this.interieurRadio.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.Highlight;
            this.ok.Cursor = System.Windows.Forms.Cursors.Default;
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ok.Location = new System.Drawing.Point(485, 649);
            this.ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(154, 28);
            this.ok.TabIndex = 12;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView.Location = new System.Drawing.Point(16, 15);
            this.treeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(307, 660);
            this.treeView.TabIndex = 10;
            // 
            // InfoActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(793, 700);
            this.Controls.Add(this.transportGB);
            this.Controls.Add(this.lieuGB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.activiteExterieureGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.treeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "InfoActivite";
            this.Text = "Informations sur l\'activité";
            this.transportGB.ResumeLayout(false);
            this.transportGB.PerformLayout();
            this.lieuGB.ResumeLayout(false);
            this.lieuGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.temps.ResumeLayout(false);
            this.temps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debutMinute)).EndInit();
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
        private System.Windows.Forms.NumericUpDown finMinute;
        private System.Windows.Forms.NumericUpDown debutMinute;

    }
}