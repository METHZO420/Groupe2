using essaiProjetExam;
using essaiProjetExam.Models;
using System.Windows.Forms;

namespace SystemeDeGestionDesEtudiants.View
{
    public partial class listedesetudiants : Form
    {
        public listedesetudiants()
        {
            InitializeComponent();
        }
        public listedesetudiants(int id)
        {
            InitializeComponent();
            using (var db = new DbExamContext())
            {
               
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
