using essaiProjetExam;
using essaiProjetExam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemeDeGestionDesEtudiants.View
{
    public partial class GestionMatiere : Form
    {
        public GestionMatiere()
        {
            InitializeComponent();
            using (var db = new DbExamContext())
            {
                cbCours.DataSource = db.Cours.ToList();
                cbCours.DisplayMember = "NomCours";
                cbCours.ValueMember = "Id";
                cbCours.SelectedIndex = -1;
            }
            actualiser();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (dataGridView1.SelectedRows != null)
                {
                    DialogResult choix = MessageBox.Show("Etes sure de voulloir Modifier l'etudiant selectionné ?", "Confirmer de la Suppression ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (choix == DialogResult.Yes)
                    {
                        int idMatiere = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                        Matieres matiereModifier = db.Set<Matieres>().Find(idMatiere);
                        matiereModifier.NomMatiere = txtNom.Text;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void GestionMatiere_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (txtNom.Text == string.Empty)
                {
                    MessageBox.Show("Veillez Saisir le nom de la matière ");
                    return;
                }
                else
                {
                    try
                    {

                        Matieres matiere = new Matieres();
                        matiere.NomMatiere = txtNom.Text;
                        db.Matieres.Add(matiere);
                        db.SaveChanges();
                        actualiser();
                        MessageBox.Show("La Matière  " + matiere.NomMatiere + " a été ajoutée avec succès");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }
        public void actualiser()
        {
            using (var db = new DbExamContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Matieres.ToList();
                txtNom.Text = "";
                cbCours.SelectedIndex = -1;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                DialogResult choix = MessageBox.Show("Etes sure de voulloir Supprimer l'etudiant selectionné ?", "Confirmer de la Suppression ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (choix == DialogResult.Yes)
                {
                    using(var db = new DbExamContext())
                    {
                        int idMatiere = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                        Matieres matiereSupprimer = db.Set<Matieres>().Find(idMatiere);
                        db.Matieres.Remove(matiereSupprimer);
                        db.SaveChanges();
                        actualiser();
                        MessageBox.Show("La Matière  " + matiereSupprimer.NomMatiere + " a été supprimée avec succès");
                    }
                }
                else
                {
                    MessageBox.Show("Suppression Annulée", "Operation annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Aucune ligne selectionner", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAssociation_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (dataGridView1.SelectedRows != null)
                {
                    DialogResult choix = MessageBox.Show("Etes sure de voulloir Associer la matière selectionné ?", "Confirmer de l'Association ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (choix == DialogResult.Yes)
                    {
                        int idMatiere = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                        int idCours = (int)cbCours.SelectedValue;
                        CoursMatieres coursMatieres = new CoursMatieres();
                        coursMatieres.IdCours = idCours;
                        coursMatieres.IdMatiere = idMatiere;
                        db.CoursMatieres.Add(coursMatieres);
                        db.SaveChanges();
                        MessageBox.Show("La Matière a été associée avec succès");
                    }
                    else
                    {
                        MessageBox.Show("Association Annulée", "Operation annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Aucune ligne selectionner", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
