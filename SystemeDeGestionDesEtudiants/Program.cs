using essaiProjetExam;
using GestionDesEtudiants.Forms;
using System;
using SystemeDeGestionDesEtudiants.View;

namespace SystemeDeGestionDesEtudiants
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var Db = new DbExamContext())
            {
                /* var etudiantsFactices = new List<Etudiants>();
                var faker = new Faker<Etudiants>("fr"); // "fr" pour des données en français
                var classes = Db.Classes.ToList();

                faker.RuleFor(e => e.Id, f => f.IndexFaker)
                     .RuleFor(e => e.Matricule, f => f.Random.Replace("########")) // Génère un matricule aléatoire
                     .RuleFor(e => e.Nom, f => f.Name.LastName())
                     .RuleFor(e => e.Prenom, f => f.Name.FirstName())
                     .RuleFor(e => e.DateNaissance, f => f.Date.Past(20, DateTime.Now.AddYears(-18))) // Génère une date de naissance aléatoire (entre 18 et 38 ans)
                     .RuleFor(e => e.Adresse, f => f.Address.StreetAddress())
                     .RuleFor(e => e.Telephone, f => f.Phone.PhoneNumber())
                     .RuleFor(e => e.Email, f => f.Internet.Email())
                     .RuleFor(e => e.Sexe, f => f.PickRandom("Homme", "Femme"))
                     .RuleFor(e => e.IdClasse, f => f.PickRandom(classes).Id) // Sélectionne un IdClasse aléatoire parmi les classes fournies
                     .RuleFor(e => e.classe, (f, e) => classes.FirstOrDefault(c => c.Id == e.IdClasse)); // Assigne la classe correspondante

                for (int i = 0; i < 13; i++)
                {
                    etudiantsFactices.Add(faker.Generate());
                    Db.SaveChanges();   
                }

                
            }
                var ClassesCoursFactices = new List<ClassesCours>();
                var faker = new Faker<ClassesCours>();
                var Cour= Db.Cours.ToList();
                var classes =Db.Classes.ToList();

                faker.RuleFor(cm => cm.IdCours, f => f.PickRandom(Cour).Id)
                     .RuleFor(cm => cm.IdClasse, f => f.PickRandom(classes).Id)
                     .RuleFor(cm => cm.Cours, (f, cm) => Cour.FirstOrDefault(c => c.Id == cm.IdCours))
                     .RuleFor(cm => cm.Classes, (f, cm) => classes.FirstOrDefault(m => m.Id == cm.IdClasse));

                for (int i = 0; i < 4; i++)
                {
                    var newClassCours = faker.Generate();
                    if (!ClassesCoursFactices.Any(cc => cc.IdClasse == newClassCours.IdClasse && cc.IdCours == newClassCours.IdCours) &&
                        !Db.ClassesCours.Any(cc => cc.IdClasse == newClassCours.IdClasse && cc.IdCours == newClassCours.IdCours))
                    {
                        ClassesCoursFactices.Add(newClassCours);
                    }
                }
                Db.ClassesCours.AddRange(ClassesCoursFactices);
                Db.SaveChanges();   */
            }

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new GestionCours());
        }
    }
}
