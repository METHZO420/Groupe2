namespace SystemeDeGestionDesEtudiants.View
{
    partial class FrmClasses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtClasse = new System.Windows.Forms.TextBox();
            this.DgClasses = new System.Windows.Forms.DataGridView();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbCours = new System.Windows.Forms.ComboBox();
            this.BtnAssCours = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnlisteetd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestions des Classes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de la Classe";
            // 
            // TxtClasse
            // 
            this.TxtClasse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtClasse.Location = new System.Drawing.Point(78, 204);
            this.TxtClasse.Name = "TxtClasse";
            this.TxtClasse.Size = new System.Drawing.Size(242, 26);
            this.TxtClasse.TabIndex = 0;
            // 
            // DgClasses
            // 
            this.DgClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgClasses.Location = new System.Drawing.Point(433, 113);
            this.DgClasses.Name = "DgClasses";
            this.DgClasses.RowHeadersWidth = 51;
            this.DgClasses.Size = new System.Drawing.Size(474, 185);
            this.DgClasses.TabIndex = 5;
            this.DgClasses.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgClasses_CellMouseDoubleClick);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouter.Location = new System.Drawing.Point(52, 463);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(149, 36);
            this.BtnAjouter.TabIndex = 1;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = false;
            this.BtnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnModifier.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnModifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifier.Location = new System.Drawing.Point(338, 463);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(164, 36);
            this.BtnModifier.TabIndex = 2;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSupprimer.Location = new System.Drawing.Point(657, 463);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(155, 36);
            this.BtnSupprimer.TabIndex = 3;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Associer un cours";
            // 
            // CbCours
            // 
            this.CbCours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CbCours.FormattingEnabled = true;
            this.CbCours.Location = new System.Drawing.Point(248, 370);
            this.CbCours.Name = "CbCours";
            this.CbCours.Size = new System.Drawing.Size(239, 28);
            this.CbCours.TabIndex = 6;
            this.CbCours.Text = "Choisir le cours";
            // 
            // BtnAssCours
            // 
            this.BtnAssCours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnAssCours.Location = new System.Drawing.Point(522, 370);
            this.BtnAssCours.Name = "BtnAssCours";
            this.BtnAssCours.Size = new System.Drawing.Size(196, 31);
            this.BtnAssCours.TabIndex = 7;
            this.BtnAssCours.Text = "&Associer Cours";
            this.BtnAssCours.UseVisualStyleBackColor = false;
            this.BtnAssCours.Click += new System.EventHandler(this.BtnAssCours_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(55, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(451, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Veuillez Sélectionner une classe pour lui assosier un cours";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnlisteetd
            // 
            this.btnlisteetd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnlisteetd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnlisteetd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnlisteetd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnlisteetd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlisteetd.Location = new System.Drawing.Point(395, 79);
            this.btnlisteetd.Name = "btnlisteetd";
            this.btnlisteetd.Size = new System.Drawing.Size(230, 28);
            this.btnlisteetd.TabIndex = 19;
            this.btnlisteetd.Text = "Liste des etudiants";
            this.btnlisteetd.UseVisualStyleBackColor = false;
            this.btnlisteetd.Click += new System.EventHandler(this.btnlisteetd_Click);
            // 
            // FrmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.btnlisteetd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnAssCours);
            this.Controls.Add(this.CbCours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.DgClasses);
            this.Controls.Add(this.TxtClasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmClasses";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.FrmClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtClasse;
        private System.Windows.Forms.DataGridView DgClasses;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbCours;
        private System.Windows.Forms.Button BtnAssCours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnlisteetd;
    }
}