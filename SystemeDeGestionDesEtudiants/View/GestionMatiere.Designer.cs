namespace SystemeDeGestionDesEtudiants.View
{
    partial class GestionMatiere
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cbCours = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAssociation = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(323, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNom.Location = new System.Drawing.Point(27, 188);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(235, 25);
            this.txtNom.TabIndex = 2;
            // 
            // cbCours
            // 
            this.cbCours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCours.FormattingEnabled = true;
            this.cbCours.Location = new System.Drawing.Point(484, 350);
            this.cbCours.Name = "cbCours";
            this.cbCours.Size = new System.Drawing.Size(224, 24);
            this.cbCours.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cours:";
            // 
            // btnAssociation
            // 
            this.btnAssociation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAssociation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAssociation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAssociation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssociation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssociation.Location = new System.Drawing.Point(718, 347);
            this.btnAssociation.Name = "btnAssociation";
            this.btnAssociation.Size = new System.Drawing.Size(183, 27);
            this.btnAssociation.TabIndex = 38;
            this.btnAssociation.Text = "Associer a un Cours";
            this.btnAssociation.UseVisualStyleBackColor = true;
            this.btnAssociation.Click += new System.EventHandler(this.btnAssociation_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(691, 451);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(183, 27);
            this.btnSupprimer.TabIndex = 39;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnModifier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(366, 451);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(183, 27);
            this.btnModifier.TabIndex = 40;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(56, 451);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(183, 27);
            this.btnAjouter.TabIndex = 41;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nom de la Matiere";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GestionMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAssociation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCours);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GestionMatiere";
            this.Text = "GestionMatiere";
            this.Load += new System.EventHandler(this.GestionMatiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cbCours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAssociation;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label1;
    }
}