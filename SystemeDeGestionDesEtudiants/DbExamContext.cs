using essaiProjetExam.Models;
using System.Data.Entity;

namespace essaiProjetExam
{
    internal class DbExamContext : DbContext
    {
        public DbExamContext() : base("examTest")
        {
        }
        public DbSet<Etudiants> Etudiants { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Matieres> Matieres { get; set; }
        public DbSet<Professeurs> Professeurs { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Utilisateurs> Utilisateurs { get; set; }
        public DbSet<OTPCode> OTPCodes { get; set; }
        public DbSet<ClassesCours> ClassesCours { get; set; }
        public DbSet<CoursMatieres> CoursMatieres { get; set; }
        public DbSet<ProfesseursMatieres> ProfesseursMatieres { get; set; }
        public DbSet<ProfesseursClasses> ProfesseursClasses { get; set; }


    }
}
