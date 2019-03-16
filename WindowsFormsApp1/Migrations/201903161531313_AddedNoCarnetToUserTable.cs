namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNoCarnetToUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "NoCarnet", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "NoCarnet");
        }
    }
}
