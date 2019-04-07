namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMoreForeignKeysEquipo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipos", "Marca_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Equipos", "Modelo_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Equipos", "Marca_Id1", c => c.Int());
            AddColumn("dbo.Equipos", "Modelo_Id1", c => c.Int());
            CreateIndex("dbo.Equipos", "Marca_Id1");
            CreateIndex("dbo.Equipos", "Modelo_Id1");
            AddForeignKey("dbo.Equipos", "Marca_Id1", "dbo.Marcas", "Id");
            AddForeignKey("dbo.Equipos", "Modelo_Id1", "dbo.Modelos", "Id");
            DropColumn("dbo.Equipos", "Marca");
            DropColumn("dbo.Equipos", "Modelo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipos", "Modelo", c => c.String());
            AddColumn("dbo.Equipos", "Marca", c => c.String());
            DropForeignKey("dbo.Equipos", "Modelo_Id1", "dbo.Modelos");
            DropForeignKey("dbo.Equipos", "Marca_Id1", "dbo.Marcas");
            DropIndex("dbo.Equipos", new[] { "Modelo_Id1" });
            DropIndex("dbo.Equipos", new[] { "Marca_Id1" });
            DropColumn("dbo.Equipos", "Modelo_Id1");
            DropColumn("dbo.Equipos", "Marca_Id1");
            DropColumn("dbo.Equipos", "Modelo_Id");
            DropColumn("dbo.Equipos", "Marca_Id");
        }
    }
}
