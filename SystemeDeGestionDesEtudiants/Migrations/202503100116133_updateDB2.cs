namespace SystemeDeGestionDesEtudiants.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updateDB2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cours", "Professeurs_Id", c => c.Int());
            CreateIndex("dbo.Cours", "Professeurs_Id");
            AddForeignKey("dbo.Cours", "Professeurs_Id", "dbo.Professeurs", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Cours", "Professeurs_Id", "dbo.Professeurs");
            DropIndex("dbo.Cours", new[] { "Professeurs_Id" });
            DropColumn("dbo.Cours", "Professeurs_Id");
        }
    }
}
