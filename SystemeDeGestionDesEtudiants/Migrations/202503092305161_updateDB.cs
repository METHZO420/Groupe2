namespace SystemeDeGestionDesEtudiants.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classes", "idCours", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "Cours_Id", c => c.Int());
            CreateIndex("dbo.Classes", "Cours_Id");
            AddForeignKey("dbo.Classes", "Cours_Id", "dbo.Cours", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Classes", "Cours_Id", "dbo.Cours");
            DropIndex("dbo.Classes", new[] { "Cours_Id" });
            DropColumn("dbo.Classes", "Cours_Id");
            DropColumn("dbo.Classes", "idCours");
        }
    }
}
