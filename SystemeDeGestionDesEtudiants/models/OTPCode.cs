using System;

namespace essaiProjetExam.Models
{
    class OTPCode
    {
        public int Id { get; set; }
        public string code { get; set; }
        public int IdUtilisateur { get; set; }

        public Utilisateurs Utilisateurs { get; set; }
        public DateTime DateExpiration { get; set; }

    }
}
