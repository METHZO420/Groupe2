using essaiProjetExam;
using essaiProjetExam.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SystemeDeGestionDesEtudiants.View
{
    public partial class GestionProf : Form
    {
        public GestionProf()
        {
            InitializeComponent();
            using(var db = new DbExamContext())
            {
                cbMatiere.DataSource = db.Matieres.ToList();
                cbMatiere.DisplayMember = "Nom";
                cbMatiere.ValueMember = "Id";
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (txtemail.Text.Contains("@"))
                {
                    Professeurs prof = new Professeurs();
                    prof.Nom = txtNom.Text;
                    prof.Prenom = txtPrenom.Text;
                    prof.Email = txtemail.Text;
                    prof.Telephone = txtTelephone.Text;
                    db.Professeurs.Add(prof);
                    db.SaveChanges();
                    actualiser();
                }
                else
                {
                    MessageBox.Show("Email invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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


                        DialogResult choix = MessageBox.Show("Voullez vous Vraiment Modifer les information du professeur ?", "Confirmer de la Modification ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (choix == DialogResult.Yes)
                        {
                            int idProf = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                            Professeurs profModifier = db.Set<Professeurs>().Find(idProf);

                            profModifier.Nom = txtNom.Text;
                            profModifier.Prenom = txtPrenom.Text;
                            profModifier.Email = txtemail.Text;
                            profModifier.Telephone = txtTelephone.Text;

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

        public void actualiser()
        {
            using (var db = new DbExamContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Professeurs.ToList();
                txtemail.Text = "";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtRecherche.Text = "";
            }
        }

        private void GestionProf_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Etes sure de voulloir Supprimer le professeur selectioné ?", "Confirmer de la Suppression ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choix == DialogResult.Yes)
            {
                using (var db = new DbExamContext())
                {
                    int idprof = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    essaiProjetExam.Models.Professeurs professeurSupprimer = db.Professeurs.Find(idprof);
                    db.Professeurs.Remove(professeurSupprimer);
                    db.SaveChanges();
                    actualiser();

                }
            }
            else
            {
                MessageBox.Show("Suppression Annulée", "Operation annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                string nomrech = txtRecherche.Text.Trim().ToLower();
                var prof = db.Professeurs.Where(c => c.Nom.ToLower().Contains(nomrech)).ToList();

                dataGridView1.DataSource = prof;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                using (var db = new DbExamContext())
                {
                    int idProf = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                    Professeurs prof = db.Professeurs.Find(idProf);
                    ProfesseursMatieres professeursMatieres = new ProfesseursMatieres();
                    int idMatiere = (int)cbMatiere.SelectedValue;
                    var proflist = db.ProfesseursMatieres.Where(c => c.IdProfesseur == idProf && c.IdMatiere == idMatiere).ToList();
                    if (proflist!= null)
                    {
                        MessageBox.Show("Le professeur est deja associé a cette matiere", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    professeursMatieres.IdProfesseur = prof.Id;
                    professeursMatieres.IdMatiere = (int)cbMatiere.SelectedValue;
                    professeursMatieres.Professeurs = prof;
                    professeursMatieres.Matieres = db.Matieres.Find((int)cbMatiere.SelectedValue);
                    db.ProfesseursMatieres.Add(professeursMatieres);
                    db.SaveChanges();
                    MessageBox.Show("Le professeur"+prof.Nom+"est associer a la matiere "+cbMatiere.Text+"","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
        }

        private void cbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
