namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsAdminToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "IsAdmin");
        }
    }
}
