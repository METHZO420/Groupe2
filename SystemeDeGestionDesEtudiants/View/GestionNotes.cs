using essaiProjetExam;
using essaiProjetExam.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SystemeDeGestionDesEtudiants.View
{
    public partial class GestionNotes : Form
    {
        public GestionNotes()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            using (var db = new DbExamContext())
            {
                comboBox1.DataSource = db.Classes.ToList();
                comboBox1.DisplayMember = "NomClasse";
                comboBox1.ValueMember = "Id";
                comboBox1.SelectedItem = null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (comboBox1.SelectedValue != null)
                {
                    Classes cl = (Classes)comboBox1.SelectedItem;
                    int idClasse = cl.Id;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = db.Etudiants.Where(s => s.IdClasse == idClasse).ToList();
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["IdClasse"].Visible = false;
                    dataGridView1.Columns["classe"].Visible = false;
                    dataGridView1.Columns["Notes"].Visible = false;
                    dataGridView1.Columns["Email"].Visible = false;
                    var li = db.ClassesCours.Where(s => s.IdClasse == idClasse).ToList();
                    var list = li.Select(s => s.IdCours).ToList();
                    var listmat = db.CoursMatieres.Where(s => list.Contains(s.IdCours)).Select(s => s.IdMatiere).ToList();
                    var matiere = db.Matieres.Where(s => listmat.Contains(s.Id)).ToList();
                    cbMatiere.DataSource = matiere;
                    cbMatiere.DisplayMember = "NomMatiere";
                    cbMatiere.ValueMember = "Id";

                }
            }
        }

        private void GestionNotes_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count !=null )
            {
                using (var db = new DbExamContext())
                {
                    int idEtudiant = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    int idMatiere = (int)cbMatiere.SelectedValue;
                    Notes note = db.Notes.FirstOrDefault(s => s.IdMatiere == idMatiere && s.IdEtudiant == idEtudiant);
                    if (note != null)
                    {
                        MessageBox.Show("L'etudiant a deja une note pour cette matiere", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else if (txtNote.Text == "")
                    {
                        MessageBox.Show("Veuillez saisir une note", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else if (float.Parse(txtNote.Text) < 0 || float.Parse(txtNote.Text) > 20)
                    {
                        MessageBox.Show("La note doit être comprise entre 0 et 20", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else if (cbMatiere.SelectedValue == null)
                    {
                        MessageBox.Show("Veuillez selectionner une matiere", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        int idClasse = (int)comboBox1.SelectedValue;
                        Notes noteajout = new Notes();
                        noteajout.IdEtudiant = idEtudiant;
                        noteajout.IdMatiere = idMatiere;
                        noteajout.etudiants = db.Etudiants.Find(idEtudiant);
                        noteajout.matieres = db.Matieres.Find(idMatiere);
                        noteajout.Note = float.Parse(txtNote.Text);
                        db.Notes.Add(noteajout);
                        db.SaveChanges();
                        actualiser();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un etudiant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void actualiser()
        {
            using (var db = new DbExamContext())
            {
                int idClasse = (int)comboBox1.SelectedValue;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Etudiants.ToList();
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["IdClasse"].Visible = false;
                dataGridView1.Columns["classe"].Visible = false;
                dataGridView1.Columns["Notes"].Visible = false;
                dataGridView1.Columns["Email"].Visible = false;
                txtNote.Text = string.Empty;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                DialogResult choix = MessageBox.Show("Etes sure de voulloir Supprimer la note de l'etudiant pour cette matiere ?", "Confirmer de la Suppression ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (choix == DialogResult.Yes)
                {
                    using (var db = new DbExamContext())
                    {
                        if (dataGridView1.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Veuillez selectionner un etudiant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (cbMatiere.SelectedValue == null)
                        {
                            MessageBox.Show("Veuillez selectionner une matiere", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (txtNote.Text == "")
                        {
                            MessageBox.Show("Veuillez saisir une note", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (float.Parse(txtNote.Text) < 0 || float.Parse(txtNote.Text) > 20)
                        {
                            MessageBox.Show("La note doit être comprise entre 0 et 20", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            int idetd = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                            int idmat = (int)cbMatiere.SelectedValue;
                            int Noteasupprimer = int.Parse(txtNote.Text);
                            Notes note = db.Notes.FirstOrDefault(s => s.IdEtudiant == idetd && s.IdMatiere == idmat && s.Note == Noteasupprimer);
                            if (note == null)
                            {
                                MessageBox.Show("L'etudiant n'a pas de note pour cette matiere", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else
                            {
                                Notes NoteSupprimer = db.Notes.Find(note.Id);
                                db.Notes.Remove(NoteSupprimer);
                                db.SaveChanges();
                                actualiser();
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Suppression Annulée", "Operation annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int idetd = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    int idMatiere = (int)cbMatiere.SelectedValue;
                    var list = db.Notes.Where(s => s.IdMatiere == idMatiere && s.IdEtudiant == idetd).ToList();
                    if (list.Count > 0)
                    {
                        MessageBox.Show("L'etudiant a deja une note pour cette matiere", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNote.Text = list[0].Note.ToString();
                    }
                }
                else
                {
                    txtNote.Text = "";
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int idetd = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    int idMatiere = (int)cbMatiere.SelectedValue;
                    var list = db.Notes.Where(s => s.IdMatiere == idMatiere && s.IdEtudiant == idetd).ToList();
                    if (list.Count > 0)
                    {
                        MessageBox.Show("L'etudiant a deja une note pour cette matiere", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNote.Text = list[0].Note.ToString();
                    }
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
                        DialogResult choix = MessageBox.Show("Voullez vous Vraiment Modifer la note de l'etudiant pour la matiere selectionner", "Confirmer de la Modification ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (choix == DialogResult.Yes)
                        {
                            int idetd = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                            int idmat = (int)cbMatiere.SelectedValue;
                            Notes note = db.Notes.FirstOrDefault(s => s.IdEtudiant == idetd && s.IdMatiere == idmat);

                            Notes noteModifier = db.Set<Notes>().Find(note.Id);
                            if (note == null)
                            {
                                MessageBox.Show("Veuillez saisir un note", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (int.Parse(txtNote.Text) > 20 || int.Parse(txtNote.Text) < 0)
                            {
                                MessageBox.Show("La note doit être comprise entre 0 et 20", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                noteModifier.Note = int.Parse(txtNote.Text);
                                db.SaveChanges();
                                actualiser();
                            }

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

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                int etudiantId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                /*  // Créer une instance du rapport
                  ReportDocument reportDocument = new ReportDocument();
                  reportDocument.Load("C:\\Users\\Hp\\source\\repos\\SystemeDeGestionDesEtudiants\\SystemeDeGestionDesEtudiants\\Rapports\\releveNote.rpt");

                  // Passer le paramètre EtudiantId au rapport
                  ParameterFieldDefinitions parameterFieldDefinitions = reportDocument.DataDefinition.ParameterFields;
                  ParameterFieldDefinition parameterFieldDefinition = parameterFieldDefinitions["EtudiantId"];
                  ParameterValues parameterValues = new ParameterValues();
                  ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                  parameterDiscreteValue.Value = etudiantId;
                  parameterValues.Add(parameterDiscreteValue);
                  parameterFieldDefinition.ApplyCurrentValues(parameterValues);

                  // Afficher le rapport dans un CrystalReportViewer
                  CrystalReportViewer reportViewer = new CrystalReportViewer();
                  reportViewer.ReportSource = reportDocument;
                  // Rafraîchir le rapport
                  reportViewer.Refresh();
              reportViewer.RefreshReport();

              // Afficher le CrystalReportViewer dans un formulaire
              Form reportForm = new BulletinNote();
                  reportForm.Controls.Add(reportViewer);

                  reportViewer.Dock = DockStyle.Fill;
                  reportForm.ShowDialog();*/

                Form bulletindenote = new BulletinNote(etudiantId);
                bulletindenote.ShowDialog();
            }

            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}



