using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaiProjetExam.Models
{
    class Etudiants
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Sexe { get; set; }
        public int IdClasse { get; set; }
        public Classes classe { get; set; }

    }
}
