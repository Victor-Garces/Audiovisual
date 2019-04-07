namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataTypeOfEquipoTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipos", "TipoTecnologiaConexion_Id", c => c.Int());
            CreateIndex("dbo.Equipos", "TipoTecnologiaConexion_Id");
            AddForeignKey("dbo.Equipos", "TipoTecnologiaConexion_Id", "dbo.TipoConexiones", "Id");
            DropColumn("dbo.Equipos", "TipoTecnologiaConexion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipos", "TipoTecnologiaConexion", c => c.Int(nullable: false));
            DropForeignKey("dbo.Equipos", "TipoTecnologiaConexion_Id", "dbo.TipoConexiones");
            DropIndex("dbo.Equipos", new[] { "TipoTecnologiaConexion_Id" });
            DropColumn("dbo.Equipos", "TipoTecnologiaConexion_Id");
        }
    }
}
