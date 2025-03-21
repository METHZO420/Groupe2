using essaiProjetExam;
using essaiProjetExam.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SystemeDeGestionDesEtudiants.View
{
    public partial class FrmClasses : Form
    {
        public FrmClasses() {
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if( TxtClasse.Text == string.Empty ) { MessageBox.Show("Veillez Saisir le nom de la classe"); return; }
            else
            {
                try
                {
                    using (var db =new DbExamContext())
                    {
                        Classes classe = new Classes();
                        classe.NomClasse = TxtClasse.Text;
                        db.Classes.Add(classe);
                        db.SaveChanges();
                        TxtClasse.Text = string.Empty;
                        FrmClasses_Load(sender, e);
                        MessageBox.Show("La Classe de " + classe.NomClasse + " a été ajoutée avec succès");
                    }
                   
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            
        }

      
        private void FrmClasses_Load(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                DgClasses.DataSource = db.Classes.Select(c => new { c.Id, c.NomClasse }).ToList();
                TxtClasse.Text = string.Empty;
                BtnModifier.Enabled = false;
                BtnSupprimer.Enabled = false;
                BtnAssCours.Enabled = false;
                CbCours.DataSource = db.Cours.ToList();
                CbCours.DisplayMember = "NomCours";
                CbCours.ValueMember = "Id";

            }
        }

       
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (DgClasses.CurrentRow == null)
            {
                MessageBox.Show("Aucune ligne sélectionnée");
                return;
            } 
            else
            {
                using (var db = new DbExamContext())
                {
                    if (int.TryParse(DgClasses.CurrentRow.Cells[0].Value.ToString(), out int id))
                    {
                        var classe = db.Classes.Find(id);
                        if (classe != null)
                        {
                            try
                            {
                                db.Classes.Remove(classe);
                                db.SaveChanges();

                                TxtClasse.Text = string.Empty;
                                FrmClasses_Load(sender, e);
                                MessageBox.Show("La Classe " + classe.NomClasse + " a été supprimée");

                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                        else MessageBox.Show("Classe introuvable");
                    }
                }
            }
        }

      
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DgClasses.CurrentRow == null) return;
            else
            {
                TxtClasse.Text = DgClasses.CurrentRow.Cells[1].Value.ToString();
                BtnModifier.Enabled = true;
                BtnSupprimer.Enabled = true;
                BtnAssCours.Enabled = true;
             
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (TxtClasse.Text == string.Empty) { MessageBox.Show("Veillez Saisir le nom de la classe"); return; }
            if (DgClasses.CurrentRow == null)
            {
                MessageBox.Show("Aucune ligne sélectionnée");
                return;
            }
            else
            {
                using (var db = new DbExamContext())
                {
                    if (int.TryParse(DgClasses.CurrentRow.Cells[0].Value.ToString(), out int id))
                    {
                        var classe = db.Classes.Find(id);
                        if (classe != null)
                        {
                            try
                            {
                                classe.NomClasse = TxtClasse.Text.Trim();
                                db.SaveChanges();

                                TxtClasse.Text = string.Empty;
                                FrmClasses_Load(sender, e);
                                MessageBox.Show("La Classe " + classe.NomClasse + " a été modifiée");

                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                        else MessageBox.Show("Classe introuvable");
                    }
                }
            }
        }

        private void DgClasses_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using ( var db = new DbExamContext()) {
                if (DgClasses.CurrentRow == null) return;
                else
                {
                    TxtClasse.Text = DgClasses.CurrentRow.Cells[1].Value.ToString();
                    BtnModifier.Enabled = true;
                    BtnSupprimer.Enabled = true;
                    BtnAssCours.Enabled = true;
                    Classes classe = db.Classes.Find(int.Parse(DgClasses.CurrentRow.Cells[0].Value.ToString()));
                    TxtClasse.Text = classe.NomClasse;

                }
            }
        }

        private void BtnAssCours_Click(object sender, EventArgs e)
        {
            if (DgClasses.CurrentRow == null)
            {
                MessageBox.Show("Aucune ligne sélectionnée");
                return;
            }
            else
            {
                using (var db = new DbExamContext())
                {
                    if (DgClasses.SelectedRows != null)
                    {
                        Classes classes = db.Classes.Find(int.Parse(DgClasses.CurrentRow.Cells[0].Value.ToString()));

                        if (classes != null)
                        {
                            try
                            {
                                var cours = db.Cours.Find(int.Parse(CbCours.SelectedValue.ToString()));
                                var classecours = new ClassesCours();
                                classecours.IdClasse = classes.Id;
                                classecours.IdCours = cours.Id;
                                classecours.Cours = cours;
                                classecours.Classes = classes;
                                var classeCours = db.ClassesCours.FirstOrDefault(cc => cc.IdClasse == classes.Id && cc.IdCours == cours.Id);
                                if (classeCours != null)
                                {
                                    MessageBox.Show("Le cours " + cours.NomCours + " a déjà été affecté à la classe " + classes.NomClasse);
                                    return;
                                }
                                else
                                {
                                    db.ClassesCours.Add(classecours);
                                    db.SaveChanges();
                                    TxtClasse.Text = string.Empty;
                                    MessageBox.Show("Le cours " + cours.NomCours + " a été affecté à la classe " + classes.NomClasse);
                                }
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                        else MessageBox.Show("Classe introuvable");
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnlisteetd_Click(object sender, EventArgs e)
        {
            using (var db = new DbExamContext())
            {
                if (DgClasses.CurrentRow == null)
                {
                    MessageBox.Show("Aucune ligne sélectionnée");
                    return;
                }
                else
                {
                    Classes classes = db.Classes.Find(int.Parse(DgClasses.CurrentRow.Cells[0].Value.ToString()));
                    if (classes != null)
                    {
                        listedesetudiants liste = new listedesetudiants(classes.Id);
                        liste.Show();
                    }
                    else
                    {
                        MessageBox.Show("Classe introuvable");
                    }
                }
            }
        }
        
    }
}

