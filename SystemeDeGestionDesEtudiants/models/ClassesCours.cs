using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaiProjetExam.Models
{
    class ClassesCours
    {
        [Key, Column(Order = 0)]
        public int IdClasse { get; set; }
        public Classes Classes { get; set; }
        [Key, Column(Order = 1)]
        public int IdCours { get; set; }
        public Cours Cours { get; set; }


    }
}
