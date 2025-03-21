using essaiProjetExam;
using essaiProjetExam.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
//using static DevExpress.Data.Helpers.SyncHelper.ZombieContextsDetector;

namespace SystemeDeGestionDesEtudiants
{
    public partial class GestionUsers : Form
    {
        public GestionUsers()
        {
            InitializeComponent();
        }


        void btnAjouter_Click(object sender, EventArgs e)
        {  
            using (var db = new DbExamContext())
            {
                essaiProjetExam.Models.Utilisateurs user = new essaiProjetExam.Models.Utilisateurs();
                user.NomUtilisateur = txtNom.Text;
                user.MotDePasse = txtMotDePasse.Text;
                user.Role = txtRole.Text;
                user.Telephone = txtTelephone.Text;

                db.Utilisateurs.Add(user);
                db.SaveChanges();
                actualiser();
            }
        }

        private void GestionUtilisateur_Load(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Utilisateurs.Select(c => new ViewUser { Id = c.Id, NomUtilisateur = c.NomUtilisateur, Role = c.Role, Telephone = c.Telephone }).ToList();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new DbExamContext())
            {
                int idUser = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                Utilisateurs user = db.Utilisateurs.Find(idUser);

                txtNom.Text = user.NomUtilisateur.ToString();
                txtMotDePasse.Text = user.MotDePasse.ToString();
                txtRole.Text = user.Role.ToString();
                txtTelephone.Text = user.Telephone.ToString();

                btnAjouter.Enabled = false;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;

            }
        }


        public void actualiser()
        {
            using (var db = new DbExamContext())
            {
                txtMotDePasse.Text = "";
                txtNom.Text = "";
                txtTelephone.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Utilisateurs.Select(c => new ViewUser { Id = c.Id, NomUtilisateur = c.NomUtilisateur, Role = c.Role, Telephone = c.Telephone }).ToList();
            }
        }

        private void GestionUsers_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                string nomrech = txtRecherche.Text.Trim().ToLower();
                var etd = db.Utilisateurs.Where(c => c.NomUtilisateur.ToLower().Contains(nomrech)).ToList();
                dataGridView1.DataSource = etd;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                using (var db = new DbExamContext())
                {


                    if (dataGridView1.SelectedRows != null)
                    {
                        DialogResult choix = MessageBox.Show("Voullez vous Vraiment Modifer l'utilisateur ?", "Confirmer de la Modification ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (choix == DialogResult.Yes)
                        {
                            int idUser = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                            Utilisateurs utilisateurModifier = db.Set<Utilisateurs>().Find(idUser);

                            utilisateurModifier.NomUtilisateur = txtNom.Text;

                            utilisateurModifier.MotDePasse = txtMotDePasse.Text;
                            utilisateurModifier.Role = txtRole.Text;
                            utilisateurModifier.Telephone = txtTelephone.Text;
                            db.SaveChanges();
                            actualiser();
                        }
                        else
                        {
                            MessageBox.Show("Modification Annulée", "Operation annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Aucune ligne selectionner", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (var db = new DbExamContext())
            {
                int idUser = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                Utilisateurs utilisateurModifier = db.Set<Utilisateurs>().Find(idUser);
                txtNom.Text = utilisateurModifier.NomUtilisateur;
                txtMotDePasse.Text = utilisateurModifier.MotDePasse;
                txtRole.Text = utilisateurModifier.Role;
                txtTelephone.Text = utilisateurModifier.Telephone;

            }

        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Etes sure de voulloir Supprimer l'utilisateur ?", "Confirmer de la Suppression ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choix == DialogResult.Yes)
            {
                using (var db = new DbExamContext())
                {
                    int idUser = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    Utilisateurs UtilisateurSupprimer = db.Utilisateurs.Find(idUser);
                    db.Utilisateurs.Remove(UtilisateurSupprimer);
                    db.SaveChanges();
                    actualiser();
                }
            }
            else
            {
                MessageBox.Show("Suppression Annulée", "Operation annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
