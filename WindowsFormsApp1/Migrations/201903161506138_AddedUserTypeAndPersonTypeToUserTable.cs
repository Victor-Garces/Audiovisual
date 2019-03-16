namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserTypeAndPersonTypeToUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "TipoPersona", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "TipoUsuario", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "TipoUsuario");
            DropColumn("dbo.Usuarios", "TipoPersona");
        }
    }
}
