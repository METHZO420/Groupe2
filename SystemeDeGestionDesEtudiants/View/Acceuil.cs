using essaiProjetExam;
using essaiProjetExam.Models;
using GestionDesEtudiants.Forms;
using System;
using System.Windows.Forms;

namespace SystemeDeGestionDesEtudiants.View
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }
        public Acceuil(int id)
        {
            var isclickeduser = false;
            InitializeComponent();
            using (var db =new DbExamContext()) 
                {
                Utilisateurs utilisateurs = db.Utilisateurs.Find(id);
                label3.Text = utilisateurs.NomUtilisateur;
                String role = utilisateurs.Role;


            }
           

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new GestionCours();
            form.ShowDialog();
        }

        private void lbUtilisateur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (label3.Text == "Administrateur")
            {
                this.Close();
                Form gestioutilisateur = new GestionUsers();
                gestioutilisateur.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas les droits pour acceder à cette page", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }

        private void label2_Click(object sender, EventArgs e)
        {

            Form connexin = new Connexion();
            connexin.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbClasse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form classe = new FrmClasses();
            classe.ShowDialog();
        }

        private void lbProfesseur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new GestionProf();
            form.ShowDialog();
        }

        private void lbMatiere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new GestionMatiere();
            form.ShowDialog();
        }

        private void lkEtudiant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new FrmEtudiants();
            form.ShowDialog();
        }
    }
}
