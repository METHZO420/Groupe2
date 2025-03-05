namespace SystemeDeGestionDesEtudiants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class misajour : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notes", "IdMatiere", c => c.Int(nullable: false));
            AddColumn("dbo.OTPCodes", "code", c => c.String());
            DropColumn("dbo.Notes", "IdMariere");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notes", "IdMariere", c => c.Int(nullable: false));
            DropColumn("dbo.OTPCodes", "code");
            DropColumn("dbo.Notes", "IdMatiere");
        }
    }
}
