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
            ((System.ComponentModel.ISupportInitialize)(this.jourFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourDebut)).BeginInit();
            this.SuspendLayout();
            // 
            // jourFin
            // 
            this.jourFin.Location = new System.Drawing.Point(606, 58);
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
            this.jourFin.Size = new System.Drawing.Size(200, 20);
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
            this.jourDebut.Location = new System.Drawing.Point(606, 24);
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
            this.jourDebut.Size = new System.Drawing.Size(200, 20);
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
            this.label4.Location = new System.Drawing.Point(493, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jour fin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jour début :";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(606, 143);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(200, 87);
            this.description.TabIndex = 4;
            this.description.KeyUp += new System.Windows.Forms.KeyEventHandler(this.touche_KeyUp);
            // 
            // nomAct
            // 
            this.nomAct.Location = new System.Drawing.Point(606, 97);
            this.nomAct.Name = "nomAct";
            this.nomAct.Size = new System.Drawing.Size(200, 20);
            this.nomAct.TabIndex = 3;
            this.nomAct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.touche_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de l\'activité :";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(474, 217);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // MoteurRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 241);
            this.Controls.Add(this.jourFin);
            this.Controls.Add(this.jourDebut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description);
            this.Controls.Add(this.nomAct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoteurRecherche";
            this.Text = "Moteur de recherche";
            ((System.ComponentModel.ISupportInitialize)(this.jourFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourDebut)).EndInit();
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
    }
}