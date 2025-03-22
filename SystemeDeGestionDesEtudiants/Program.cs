using essaiProjetExam;
using GestionDesEtudiants.Forms;
using System;
using SystemeDeGestionDesEtudiants.View;

namespace SystemeDeGestionDesEtudiants
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Connexion());
        }
    }
}
