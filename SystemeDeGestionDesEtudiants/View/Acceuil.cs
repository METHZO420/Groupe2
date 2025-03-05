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
    public partial class Acceuil: Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }
        public Acceuil(string nom)
        {
            InitializeComponent();
            label3.Text = nom;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lbUtilisateur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form gestioutilisateur = new GestionUsers();
            gestioutilisateur.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            this.Close();
            Form connexin = new Connexion();
            connexin.ShowDialog();
        }
    }
}
