namespace SystemeDeGestionDesEtudiants.View
{
    partial class Acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.label1 = new System.Windows.Forms.Label();
            this.lbUtilisateur = new System.Windows.Forms.LinkLabel();
            this.lbClasse = new System.Windows.Forms.LinkLabel();
            this.lbCours = new System.Windows.Forms.LinkLabel();
            this.lbMatiere = new System.Windows.Forms.LinkLabel();
            this.lbProfesseur = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lkEtudiant = new System.Windows.Forms.LinkLabel();
            this.lkGestionNote = new System.Windows.Forms.LinkLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "------------------------------------------------------------------------";
            // 
            // lbUtilisateur
            // 
            this.lbUtilisateur.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbUtilisateur.AutoSize = true;
            this.lbUtilisateur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUtilisateur.LinkColor = System.Drawing.Color.Black;
            this.lbUtilisateur.Location = new System.Drawing.Point(36, 98);
            this.lbUtilisateur.Name = "lbUtilisateur";
            this.lbUtilisateur.Size = new System.Drawing.Size(201, 23);
            this.lbUtilisateur.TabIndex = 1;
            this.lbUtilisateur.TabStop = true;
            this.lbUtilisateur.Text = "Gestion Utilisateurs";
            this.lbUtilisateur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbUtilisateur_LinkClicked);
            // 
            // lbClasse
            // 
            this.lbClasse.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbClasse.AutoSize = true;
            this.lbClasse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClasse.LinkColor = System.Drawing.Color.Black;
            this.lbClasse.Location = new System.Drawing.Point(36, 320);
            this.lbClasse.Name = "lbClasse";
            this.lbClasse.Size = new System.Drawing.Size(167, 23);
            this.lbClasse.TabIndex = 2;
            this.lbClasse.TabStop = true;
            this.lbClasse.Text = "Gestion Classes";
            this.lbClasse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbClasse_LinkClicked);
            // 
            // lbCours
            // 
            this.lbCours.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbCours.AutoSize = true;
            this.lbCours.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCours.LinkColor = System.Drawing.Color.Black;
            this.lbCours.Location = new System.Drawing.Point(36, 393);
            this.lbCours.Name = "lbCours";
            this.lbCours.Size = new System.Drawing.Size(149, 23);
            this.lbCours.TabIndex = 3;
            this.lbCours.TabStop = true;
            this.lbCours.Text = "Gestion Cours";
            this.lbCours.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // lbMatiere
            // 
            this.lbMatiere.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbMatiere.AutoSize = true;
            this.lbMatiere.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatiere.LinkColor = System.Drawing.Color.Black;
            this.lbMatiere.Location = new System.Drawing.Point(36, 240);
            this.lbMatiere.Name = "lbMatiere";
            this.lbMatiere.Size = new System.Drawing.Size(175, 23);
            this.lbMatiere.TabIndex = 4;
            this.lbMatiere.TabStop = true;
            this.lbMatiere.Text = "Gestion Matieres";
            this.lbMatiere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbMatiere_LinkClicked);
            // 
            // lbProfesseur
            // 
            this.lbProfesseur.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbProfesseur.AutoSize = true;
            this.lbProfesseur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfesseur.LinkColor = System.Drawing.Color.Black;
            this.lbProfesseur.Location = new System.Drawing.Point(36, 169);
            this.lbProfesseur.Name = "lbProfesseur";
            this.lbProfesseur.Size = new System.Drawing.Size(209, 23);
            this.lbProfesseur.TabIndex = 5;
            this.lbProfesseur.TabStop = true;
            this.lbProfesseur.Text = "Gestion Professeurs";
            this.lbProfesseur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbProfesseur_LinkClicked);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Se deconnecter";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Administrateur";
            // 
            // lkEtudiant
            // 
            this.lkEtudiant.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkEtudiant.AutoSize = true;
            this.lkEtudiant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkEtudiant.LinkColor = System.Drawing.Color.Black;
            this.lkEtudiant.Location = new System.Drawing.Point(36, 455);
            this.lkEtudiant.Name = "lkEtudiant";
            this.lkEtudiant.Size = new System.Drawing.Size(182, 23);
            this.lkEtudiant.TabIndex = 8;
            this.lkEtudiant.TabStop = true;
            this.lkEtudiant.Text = "Gestion Etudiants";
            this.lkEtudiant.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkEtudiant_LinkClicked);
            // 
            // lkGestionNote
            // 
            this.lkGestionNote.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkGestionNote.AutoSize = true;
            this.lkGestionNote.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkGestionNote.LinkColor = System.Drawing.Color.Black;
            this.lkGestionNote.Location = new System.Drawing.Point(36, 525);
            this.lkGestionNote.Name = "lkGestionNote";
            this.lkGestionNote.Size = new System.Drawing.Size(147, 23);
            this.lkGestionNote.TabIndex = 9;
            this.lkGestionNote.TabStop = true;
            this.lkGestionNote.Text = "Gestion Notes";
            this.lkGestionNote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkGestionNote_LinkClicked);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 629);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.lkGestionNote);
            this.panel1.Controls.Add(this.lkEtudiant);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbProfesseur);
            this.panel1.Controls.Add(this.lbMatiere);
            this.panel1.Controls.Add(this.lbCours);
            this.panel1.Controls.Add(this.lbClasse);
            this.panel1.Controls.Add(this.lbUtilisateur);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 629);
            this.panel1.TabIndex = 0;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1106, 622);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acceuil";
            this.ShowInTaskbar = false;
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbUtilisateur;
        private System.Windows.Forms.LinkLabel lbClasse;
        private System.Windows.Forms.LinkLabel lbCours;
        private System.Windows.Forms.LinkLabel lbMatiere;
        private System.Windows.Forms.LinkLabel lbProfesseur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lkEtudiant;
        private System.Windows.Forms.LinkLabel lkGestionNote;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
    }
}