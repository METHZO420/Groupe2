using essaiProjetExam;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SystemeDeGestionDesEtudiants.View
{
    public partial class BulletinNote : Form
    {
        private int _etudiantId;

        public BulletinNote(int etudiantId)
        {
            InitializeComponent();
            _etudiantId = etudiantId;
            LoadReport();
        }

        private void LoadReport()
        {
           using (var db = new DbExamContext())
            {
                
            }
        }
    }
}