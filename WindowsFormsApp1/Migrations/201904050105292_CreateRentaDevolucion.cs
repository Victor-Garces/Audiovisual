namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRentaDevolucion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RentaDevoluciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaPrestamo = c.DateTime(nullable: false),
                        FechaDevolucion = c.DateTime(nullable: false),
                        Comentario = c.String(),
                        Estado = c.Boolean(nullable: false),
                        Empleado_Id = c.Int(),
                        Equipo_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleados", t => t.Empleado_Id)
                .ForeignKey("dbo.Equipos", t => t.Equipo_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Empleado_Id)
                .Index(t => t.Equipo_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentaDevolucions", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.RentaDevolucions", "Equipo_Id", "dbo.Equipoes");
            DropForeignKey("dbo.RentaDevolucions", "Empleado_Id", "dbo.Empleadoes");
            DropIndex("dbo.RentaDevolucions", new[] { "Usuario_Id" });
            DropIndex("dbo.RentaDevolucions", new[] { "Equipo_Id" });
            DropIndex("dbo.RentaDevolucions", new[] { "Empleado_Id" });
            DropTable("dbo.RentaDevolucions");
        }
    }
}
