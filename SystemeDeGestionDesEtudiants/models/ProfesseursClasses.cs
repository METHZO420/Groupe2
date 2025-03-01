using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaiProjetExam.Models
{
    class ProfesseursClasses
    {
        [Key, Column(Order = 0)]
        public int ProfesseurId { get; set; }
        public Professeurs Professeurs { get; set; }
        [Key, Column(Order = 1)]
        public int ClasseId { get; set; }
        public Classes Classes { get; set; }
    }
}
