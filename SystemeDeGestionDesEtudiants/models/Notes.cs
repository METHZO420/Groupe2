namespace essaiProjetExam.Models
{
    class Notes
    {
        public int Id { get; set; }
        public int IdEtudiant { get; set; }
        public Etudiants etudiants { get; set; }

        public int IdMatiere { get; set; }
        public Matieres matieres { get; set; }
        public float Note { get; set; }

    }
}
