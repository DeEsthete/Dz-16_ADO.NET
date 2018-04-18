namespace Dz_16.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTextAge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.News", "Text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "Text");
            DropColumn("dbo.Authors", "Age");
        }
    }
}
