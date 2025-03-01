using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaiProjetExam.Models
{
    class Utilisateurs
    {
        public int Id { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; }
        public string Telephone { get; set; }
    }
}
