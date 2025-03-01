using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaiProjetExam.Models
{
    class ProfesseursMatieres
    {
        [Key, Column(Order = 0)]
        public int IdProfesseur { get; set; }
        public Professeurs Professeurs { get; set; }
        [Key, Column(Order = 1)]
        public int IdMatiere { get; set; }
        public Matieres Matieres { get; set; }
    }
}
