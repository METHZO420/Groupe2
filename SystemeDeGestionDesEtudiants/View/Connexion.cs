using essaiProjetExam;
using essaiProjetExam.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using SystemeDeGestionDesEtudiants.View;
using Twilio;
using Twilio.Rest.Verify.V2.Service;
namespace SystemeDeGestionDesEtudiants
{
    public partial class Connexion : Form
    {
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
                    MessageBox.Show("Veuillez saisir l'otp qui vous envoyer par SMS dans le champ CODE OTP", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string accountSid = "AC1d58649cc707b259d9a44f6276a73302";
                    string authToken = "b7f28e158bf9fbd6feba2b29c291da3b";
                    //   string twilioPhoneNumber = "+221781492188"; // Votre numéro Twilio
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


            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
        }

        private void btnValideOTP_Click(object sender, EventArgs e)
        {
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
                            to: "+221" + user.Telephone,
                            code: otpCode,
                            pathServiceSid: "VA4b3f986a379f881759a710927eff53a5"
                        );

                        if (verificationCheck.Status == "approved")
                        {
                            OTPCode otp = new OTPCode();
                            otp.IdUtilisateur = user.Id;
                            otp.DateExpiration = DateTime.Now.AddMinutes(10);
                            otp.Utilisateurs = user;
                            otp.code = otpCode;
                            db.OTPCodes.Add(otp);
                            db.SaveChanges();
                            MessageBox.Show("Code OTP valide. Accès autorisé.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form acceuil = new Acceuil(user.Id);
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



