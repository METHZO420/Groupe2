using essaiProjetExam;
using essaiProjetExam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemeDeGestionDesEtudiants.View;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Rest.Verify.V2.Service;
using Twilio.Types;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SystemeDeGestionDesEtudiants
{
    public partial class Connexion : Form
    {
        bool btnclick = false;

        public Connexion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
          
            txtOTP.ReadOnly = false;

            string nom = txtNomUtilisateur.Text;
            string mdp = txtMotDePasse.Text;
            using (var db = new DbExamContext())
            {
                var user = db.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == nom && u.MotDePasse == mdp);
                if (user != null)
                {
                    MessageBox.Show("Veuillez saisir l'otp qui vous envoyer par SMS dans le champ CODE OTP","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    string accountSid = "AC1d58649cc707b259d9a44f6276a73302";
                    string authToken = "15a3b2b09da9d93e912b9656f630a22b";
                    string twilioPhoneNumber = "+221781492188"; // Votre numéro Twilio
                    string recipientPhoneNumber = "+221" + user.Telephone; // Numéro du destinataire
                    TwilioClient.Init(accountSid, authToken);

                    // Envoyer un OTP avec Twilio Verify
                    var verification = VerificationResource.Create(
                        to: "+221" + user.Telephone, // Numéro de téléphone de l'utilisateur
                        channel: VerificationResource.ChannelEnum.Sms.ToString(),
                        pathServiceSid: "VA4b3f986a379f881759a710927eff53a5" // SID de votre service Twilio Verify
                    );
                }

                else
                {
                    MessageBox.Show("Nom d'utilisateur ou Mot de passe Incorect", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                /* string nom = txtNomUtilisateur.Text;
                     string mdp = txtMotDePasse.Text;
                     using (var db=new DbExamContext())
                     {
                         var user = db.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == nom && u.MotDePasse == mdp);

                         if(user != null)
                         {
                             Form acceuil = new Acceuil(nom);
                             acceuil.ShowDialog();

                         }
                         else
                         {
                             MessageBox.Show("Nom d'utilisateur ou Mot de passe Incorect");
                         }
                     }*/
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
        }

        private void btnValideOTP_Click(object sender, EventArgs e)
        {
            btnclick = true;
        }
        private void VerifierOTP(string otpCode)

        {

            string nom = txtNomUtilisateur.Text;
            string mdp = txtMotDePasse.Text;
            using (var db = new DbExamContext())
            {
                var user = db.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == nom && u.MotDePasse == mdp);
                if (user != null)
                {
                    try
                    {
                        var verificationCheck = VerificationCheckResource.Create(
                            to:"+221"+ user.Telephone ,
                            code: otpCode,
                            pathServiceSid: "VA4b3f986a379f881759a710927eff53a5"
                        );

                        if (verificationCheck.Status == "approved")
                        {
                            OTPCode otp = new OTPCode();
                            otp.IdUtilisateur = user.Id;
                            otp.DateExpiration = DateTime.Now.AddMinutes(30);
                            otp.Utilisateurs = user;
                            db.OTPCodes.Add(otp);
                            db.SaveChanges();
                            MessageBox.Show("Code OTP valide. Accès autorisé.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form acceuil = new Acceuil(txtNomUtilisateur.Text);
                            acceuil.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Code OTP invalide ou expiré.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Twilio.Exceptions.ApiException ex)
                    {

                        MessageBox.Show($"Erreur Twilio : {ex.Message}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
        }
    }

        private void txtOTP_TextChanged(object sender, EventArgs e)
        {
            string otpCode = txtOTP.Text;
            string nom = txtNomUtilisateur.Text;
            string mdp = txtMotDePasse.Text;
            if (otpCode.Length == 6)
            {
                using (var db = new DbExamContext())
                {
                   
                    VerifierOTP(otpCode);
                }
            }
        }
    }
}



