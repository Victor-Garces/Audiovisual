namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeysEquipo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Equipos", "TipoEquipo_Id", "dbo.TipoEquipos");
            DropIndex("dbo.Equipos", new[] { "TipoEquipo_Id" });
            AddColumn("dbo.Equipos", "TipoConexion_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Equipos", "TipoEquipo_Id1", c => c.Int());
            AlterColumn("dbo.Equipos", "TipoEquipo_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Equipos", "TipoEquipo_Id1");
            AddForeignKey("dbo.Equipos", "TipoEquipo_Id1", "dbo.TipoEquipos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipos", "TipoEquipo_Id1", "dbo.TipoEquipos");
            DropIndex("dbo.Equipos", new[] { "TipoEquipo_Id1" });
            AlterColumn("dbo.Equipos", "TipoEquipo_Id", c => c.Int());
            DropColumn("dbo.Equipos", "TipoEquipo_Id1");
            DropColumn("dbo.Equipos", "TipoConexion_Id");
            CreateIndex("dbo.Equipos", "TipoEquipo_Id");
            AddForeignKey("dbo.Equipos", "TipoEquipo_Id", "dbo.TipoEquipos", "Id");
        }
    }
}
