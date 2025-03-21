using System.Collections.Generic;

namespace essaiProjetExam.Models
{
    class Classes
    {
        public int Id { get; set; }
        public string NomClasse { get; set; }
        public int idCours { get; set; }
        public Cours Cours { get; set; }

        public ICollection<Etudiants> Etudiants { get; set; }
        public ICollection<ClassesCours> ClassesCours { get; set; }
    }
}
