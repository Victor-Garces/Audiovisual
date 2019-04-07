namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Cedula = c.String(),
                        Tanda = c.Int(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Equipos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        NoSerial = c.Int(nullable: false),
                        Marca = c.String(),
                        Modelo = c.String(),
                        TipoTecnologiaConexion = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        TipoEquipo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoEquipos", t => t.TipoEquipo_Id)
                .Index(t => t.TipoEquipo_Id);
            
            CreateTable(
                "dbo.TipoEquipos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modelos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.Boolean(nullable: false),
                        Marca_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.Marca_Id)
                .Index(t => t.Marca_Id);
            
            CreateTable(
                "dbo.TipoConexiones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Cedula = c.String(),
                        NoCarnet = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        TipoPersona = c.Int(nullable: false),
                        TipoUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Modelos", "Marca_Id", "dbo.Marcas");
            DropForeignKey("dbo.Equipos", "TipoEquipo_Id", "dbo.TipoEquipos");
            DropIndex("dbo.Modelos", new[] { "Marca_Id" });
            DropIndex("dbo.Equipos", new[] { "TipoEquipo_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.TipoConexiones");
            DropTable("dbo.Modelos");
            DropTable("dbo.Marcas");
            DropTable("dbo.TipoEquipos");
            DropTable("dbo.Equipos");
            DropTable("dbo.Empleados");
        }
    }
}
