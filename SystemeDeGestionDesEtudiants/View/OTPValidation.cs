using System;
using System.Windows.Forms;

namespace SystemeDeGestionDesEtudiants.View
{
    public partial class OTPValidation : Form
    {
        public OTPValidation()
        {
            InitializeComponent();
        }
        public OTPValidation(string code)
        {

            InitializeComponent();
            txtinvisible.Text = code;
        }

        private void btnVerifier_Click(object sender, EventArgs e)
        {
            if (txtinvisible.Text == txtCode.Text)
            {
                Form acceuil = new Acceuil();
                acceuil.ShowDialog();
            }

        }
    }
}
