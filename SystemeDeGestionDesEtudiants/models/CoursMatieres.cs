using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaiProjetExam.Models
{
    internal class CoursMatieres
    {
        [Key , Column (Order =0)]
        public int IdCours { get; set; }
        public Cours Cours { get; set; }
        [Key, Column(Order = 1)]
        public int IdMatiere { get; set; }
        public Matieres Matieres { get; set; }
    }
}
