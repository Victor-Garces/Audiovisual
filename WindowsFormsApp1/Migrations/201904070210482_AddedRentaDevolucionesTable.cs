namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRentaDevolucionesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RentaDevoluciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Empleado_Id = c.Int(nullable: false),
                        Equipo_Id = c.Int(nullable: false),
                        Usuario_Id = c.Int(nullable: false),
                        FechaPrestamo = c.DateTime(nullable: false),
                        FechaDevolucion = c.DateTime(nullable: false),
                        Comentario = c.String(),
                        Estado = c.Boolean(nullable: false),
                        Empleado_Id1 = c.Int(),
                        Equipo_Id1 = c.Int(),
                        Usuario_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleados", t => t.Empleado_Id1)
                .ForeignKey("dbo.Equipos", t => t.Equipo_Id1)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id1)
                .Index(t => t.Empleado_Id1)
                .Index(t => t.Equipo_Id1)
                .Index(t => t.Usuario_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentaDevoluciones", "Usuario_Id1", "dbo.Usuarios");
            DropForeignKey("dbo.RentaDevoluciones", "Equipo_Id1", "dbo.Equipos");
            DropForeignKey("dbo.RentaDevoluciones", "Empleado_Id1", "dbo.Empleados");
            DropIndex("dbo.RentaDevoluciones", new[] { "Usuario_Id1" });
            DropIndex("dbo.RentaDevoluciones", new[] { "Equipo_Id1" });
            DropIndex("dbo.RentaDevoluciones", new[] { "Empleado_Id1" });
            DropTable("dbo.RentaDevoluciones");
        }
    }
}
