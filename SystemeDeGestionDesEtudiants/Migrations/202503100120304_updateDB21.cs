namespace SystemeDeGestionDesEtudiants.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updateDB21 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cours", "Professeurs_Id", "dbo.Professeurs");
            DropIndex("dbo.Cours", new[] { "Professeurs_Id" });
            DropColumn("dbo.Cours", "Professeurs_Id");
        }

        public override void Down()
        {
            AddColumn("dbo.Cours", "Professeurs_Id", c => c.Int());
            CreateIndex("dbo.Cours", "Professeurs_Id");
            AddForeignKey("dbo.Cours", "Professeurs_Id", "dbo.Professeurs", "Id");
        }
    }
}
