using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using essaiProjetExam;
using essaiProjetExam.Models;


namespace GestionDesEtudiants.Forms
{
    public partial class FrmEtudiants : Form
    {
        public FrmEtudiants()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Etudiants.Where(c => c.Nom.Contains(textBox1.Text)).ToList();
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Notes"].Visible = false;
                dataGridView1.Columns["classe"].Visible = false;
                dataGridView1.Columns["IdClasse"].Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if(dataGridView1.Rows.Count == 0)
                {
                    int idetd = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                    Etudiants etudiants = db.Etudiants.Find(idetd);
                    txtAdresse.Text= etudiants.Adresse;
                    txtMail.Text = etudiants.Email;
                    txtNom.Text = etudiants.Nom;
                    txtPrenom.Text = etudiants.Prenom;
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if(txtAdresse.Text=="" || txtNom.Text=="" || txtPrenom.Text=="" || txtTelephone.Text=="" || cbClasse.SelectedIndex==null || cbSexe.SelectedIndex==null)
                {
                    MessageBox.Show("Veuillez saisir tout les champs");
                }
                else
                {
                    Etudiants etudiants = new Etudiants();
                    etudiants.Nom = txtNom.Text;
                    etudiants.Prenom = txtPrenom.Text;
                    etudiants.Email = txtMail.Text;
                    etudiants.Adresse = txtAdresse.Text;
                    etudiants.DateNaissance = DateTime.Parse(dateTimePicker1.Text);
                    etudiants.Matricule = cbClasse.SelectedText+"00"+etudiants.Id+DateTime.Now.Year.ToString();
                    if (cbClasse.SelectedIndex == 0)
                    {
                        etudiants.Sexe = "Homme";
                    }
                    else 
                    {
                        etudiants.Sexe = "Femme";
                    }
                    etudiants.Telephone = txtTelephone.Text;
                    int idcl = (int)cbClasse.SelectedValue;
                    Classes classes = db.Classes.Find(idcl);
                    etudiants.classe =classes;
                    etudiants.IdClasse =idcl;
                    db.Etudiants.Add(etudiants);
                    db.SaveChanges();
                    actualiser();

                }
            }
        }

        private void FrmEtudiants_Load(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Etudiants.ToList();
                dataGridView1.Columns["Id"].Visible = false;
                cbClasse.DataSource = db.Classes.ToList();
                cbClasse.DisplayMember = "NomClasse";
                cbClasse.ValueMember = "Id";
            }
        }

        private void cbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult choix = MessageBox.Show("Voullez vous Vraiment Modifier les information de l'etudiant  selectionné", "Confirmer de la Modification ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (choix == DialogResult.Yes)
                    {

                        int etudiantId = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                        Etudiants etdModifier = db.Set<Etudiants>().Find(etudiantId);
                        if (etdModifier == null)
                        {
                            MessageBox.Show("Veuillez selectionner un etudiant", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (txtAdresse.Text == "" || txtNom.Text == "" || txtPrenom.Text == "" || txtTelephone.Text == "" || cbClasse.SelectedIndex == null || cbSexe.SelectedIndex == null)
                        {
                            MessageBox.Show("Veuillez saisir tout les champs");
                        }
                        else
                        {
                            etdModifier.Nom = txtNom.Text;
                            etdModifier.Prenom = txtPrenom.Text;
                            etdModifier.Email = txtMail.Text;
                            etdModifier.Adresse = txtAdresse.Text;
                            etdModifier.DateNaissance = DateTime.Parse(dateTimePicker1.Text);
                            etdModifier.Matricule = cbClasse.SelectedText + "00" + etdModifier.Id + DateTime.Now.Year.ToString();
                            etdModifier.Telephone= txtTelephone.Text;
                            if (cbClasse.SelectedIndex == 0)
                            {
                                etdModifier.Sexe = "Homme";
                            }
                            else
                            {
                                etdModifier.Sexe = "Femme";
                            }
                            int idcl = (int)cbClasse.SelectedValue;
                            Classes classes = db.Classes.Find(idcl);
                            etdModifier.classe = classes;
                            etdModifier.IdClasse = idcl;
                            db.SaveChanges();
                            actualiser();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Modification Annulée");
                    }
                }
                else
                {
                    MessageBox.Show("Aucun Etudiant n'est selectionner");
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (dataGridView1.SelectedRows != null)
                {
                    DialogResult choix = MessageBox.Show("Etes sure de voulloir Supprimer l'etudiant selectionné ?", "Confirmer de la Suppression ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (choix == DialogResult.Yes)
                    {
                        int idetd = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                        Etudiants etdSupprimer = db.Etudiants.FirstOrDefault(c => c.Id == idetd);
                        var listnote= db.Notes.Where(c => c.IdEtudiant == idetd).ToList();
                        if (etdSupprimer != null)
                        {
                            db.Notes.RemoveRange(listnote);
                            db.Etudiants.Remove(etdSupprimer);
                            db.SaveChanges();
                            actualiser();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Suppression Annulée");
                    }
                }
                else
                {
                    MessageBox.Show("Aucun Etudiant n'est selectionner");
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void actualiser()
        {
            using (var db = new DbExamContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Etudiants.Where(c => c.Nom.Contains(textBox1.Text)).ToList();
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Notes"].Visible = false;
                dataGridView1.Columns["classe"].Visible = false;
                dataGridView1.Columns["IdClasse"].Visible = false;
            }
            txtAdresse.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            cbClasse.SelectedIndex = 0;
            textBox1.Text = string.Empty;


        }
    }
}
