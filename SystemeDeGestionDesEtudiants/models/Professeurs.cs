using System.Collections.Generic;

namespace essaiProjetExam.Models
{
    class Professeurs
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public ICollection<ProfesseursMatieres> ProfesseursMatieres { get; set; }
        partial class ViewProf
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Email { get; set; }
            public string Telephone { get; set; }
        }
    }
}
