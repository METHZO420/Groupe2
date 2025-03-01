namespace SystemeDeGestionDesEtudiants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mymigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClassesCours",
                c => new
                    {
                        IdClasse = c.Int(nullable: false),
                        IdCours = c.Int(nullable: false),
                        Classes_Id = c.Int(),
                        Cours_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.IdClasse, t.IdCours })
                .ForeignKey("dbo.Classes", t => t.Classes_Id)
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .Index(t => t.Classes_Id)
                .Index(t => t.Cours_Id);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoursMatieres",
                c => new
                    {
                        IdCours = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        Cours_Id = c.Int(),
                        Matieres_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.IdCours, t.IdMatiere })
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .ForeignKey("dbo.Matieres", t => t.Matieres_Id)
                .Index(t => t.Cours_Id)
                .Index(t => t.Matieres_Id);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatiere = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Adresse = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        Sexe = c.String(),
                        IdClasse = c.Int(nullable: false),
                        classe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.classe_Id)
                .Index(t => t.classe_Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEtudiant = c.Int(nullable: false),
                        IdMariere = c.Int(nullable: false),
                        Note = c.Single(nullable: false),
                        etudiants_Id = c.Int(),
                        matieres_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.etudiants_Id)
                .ForeignKey("dbo.Matieres", t => t.matieres_Id)
                .Index(t => t.etudiants_Id)
                .Index(t => t.matieres_Id);
            
            CreateTable(
                "dbo.OTPCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUtilisateur = c.Int(nullable: false),
                        DateExpiration = c.DateTime(nullable: false),
                        Utilisateurs_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.Utilisateurs_Id)
                .Index(t => t.Utilisateurs_Id);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(),
                        MotDePasse = c.String(),
                        Role = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfesseursClasses",
                c => new
                    {
                        ProfesseurId = c.Int(nullable: false),
                        ClasseId = c.Int(nullable: false),
                        Classes_Id = c.Int(),
                        Professeurs_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.ProfesseurId, t.ClasseId })
                .ForeignKey("dbo.Classes", t => t.Classes_Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeurs_Id)
                .Index(t => t.Classes_Id)
                .Index(t => t.Professeurs_Id);
            
            CreateTable(
                "dbo.ProfesseursMatieres",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        Matieres_Id = c.Int(),
                        Professeurs_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.IdProfesseur, t.IdMatiere })
                .ForeignKey("dbo.Matieres", t => t.Matieres_Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeurs_Id)
                .Index(t => t.Matieres_Id)
                .Index(t => t.Professeurs_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfesseursMatieres", "Professeurs_Id", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursMatieres", "Matieres_Id", "dbo.Matieres");
            DropForeignKey("dbo.ProfesseursClasses", "Professeurs_Id", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursClasses", "Classes_Id", "dbo.Classes");
            DropForeignKey("dbo.OTPCodes", "Utilisateurs_Id", "dbo.Utilisateurs");
            DropForeignKey("dbo.Notes", "matieres_Id", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "etudiants_Id", "dbo.Etudiants");
            DropForeignKey("dbo.Etudiants", "classe_Id", "dbo.Classes");
            DropForeignKey("dbo.CoursMatieres", "Matieres_Id", "dbo.Matieres");
            DropForeignKey("dbo.CoursMatieres", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.ClassesCours", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.ClassesCours", "Classes_Id", "dbo.Classes");
            DropIndex("dbo.ProfesseursMatieres", new[] { "Professeurs_Id" });
            DropIndex("dbo.ProfesseursMatieres", new[] { "Matieres_Id" });
            DropIndex("dbo.ProfesseursClasses", new[] { "Professeurs_Id" });
            DropIndex("dbo.ProfesseursClasses", new[] { "Classes_Id" });
            DropIndex("dbo.OTPCodes", new[] { "Utilisateurs_Id" });
            DropIndex("dbo.Notes", new[] { "matieres_Id" });
            DropIndex("dbo.Notes", new[] { "etudiants_Id" });
            DropIndex("dbo.Etudiants", new[] { "classe_Id" });
            DropIndex("dbo.CoursMatieres", new[] { "Matieres_Id" });
            DropIndex("dbo.CoursMatieres", new[] { "Cours_Id" });
            DropIndex("dbo.ClassesCours", new[] { "Cours_Id" });
            DropIndex("dbo.ClassesCours", new[] { "Classes_Id" });
            DropTable("dbo.ProfesseursMatieres");
            DropTable("dbo.ProfesseursClasses");
            DropTable("dbo.Professeurs");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.OTPCodes");
            DropTable("dbo.Notes");
            DropTable("dbo.Etudiants");
            DropTable("dbo.Matieres");
            DropTable("dbo.CoursMatieres");
            DropTable("dbo.Cours");
            DropTable("dbo.ClassesCours");
            DropTable("dbo.Classes");
        }
    }
}
