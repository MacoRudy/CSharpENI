namespace TP5Samourai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ArtMartials", "Nom", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ArtMartials", "Nom", c => c.Int(nullable: false));
        }
    }
}
