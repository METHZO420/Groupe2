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
    public partial class GestionCours : Form
    {
        public GestionCours()
        {
            InitializeComponent();
            actualiser();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (dataGridView1.SelectedRows != null)
                {
                    DialogResult choix = MessageBox.Show("Etes sure de voulloir Modifier le cours selectionné ?", "Confirmer de la Suppression ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (choix == DialogResult.Yes)
                    {
                        int idCours = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                        Cours coursModifier = db.Set<Cours>().Find(idCours);
                        coursModifier.NomCours = txtNom.Text;
                        coursModifier.Description = txtDescription.Text;
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                Cours cours = new Cours();
                cours.NomCours = txtNom.Text;
                cours.Description = txtDescription.Text;
                db.Cours.Add(cours);
                db.SaveChanges();
                actualiser();
            }
        }
        public void actualiser()
        {
            using (var db = new DbExamContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Cours.Select(c => new { c.Id, c.NomCours, c.Description }).ToList();
                txtNom.Text = "";
                txtDescription.Text = "";
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (dataGridView1.SelectedRows != null)
                {
                    DialogResult choix = MessageBox.Show("Etes sure de voulloir Supprimer le cours selectionné ?", "Confirmer de la Suppression ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (choix == DialogResult.Yes)
                    {
                        int idCours = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                        Cours coursSupprimer = db.Set<Cours>().Find(idCours);
                        db.Cours.Remove(coursSupprimer);
                        db.SaveChanges();
                        actualiser();
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
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using(var db =new DbExamContext())
            {
                if (dataGridView1.SelectedRows != null)
                {
                    int idCours = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    Cours cours = db.Cours.Find(idCours);
                    txtNom.Text = cours.NomCours;
                    txtDescription.Text = cours.Description;
                }
                else
                {
                    MessageBox.Show("Aucune ligne selectionner", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
