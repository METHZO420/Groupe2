using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaiProjetExam.Models
{
    class Notes
    {
        public int Id { get; set; }
        public int IdEtudiant { get; set; }
        public Etudiants etudiants { get; set; }

        public int IdMariere { get; set; }
        public Matieres matieres { get; set; }
        public float Note { get; set; }

    }
}
