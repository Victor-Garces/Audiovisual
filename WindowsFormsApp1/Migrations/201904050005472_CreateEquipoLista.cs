namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEquipoLista : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoEquipos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Equipos", "TipoEquipo_Id", c => c.Int());
            CreateIndex("dbo.Equipos", "TipoEquipo_Id");
            AddForeignKey("dbo.Equipos", "TipoEquipo_Id", "dbo.TipoEquipos", "Id");
            DropColumn("dbo.Equipos", "TipoEquipo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipoes", "TipoEquipo", c => c.Int(nullable: false));
            DropForeignKey("dbo.Equipoes", "TipoEquipo_Id", "dbo.TipoEquipoes");
            DropIndex("dbo.Equipoes", new[] { "TipoEquipo_Id" });
            DropColumn("dbo.Equipoes", "TipoEquipo_Id");
            DropTable("dbo.TipoEquipoes");
        }
    }
}
