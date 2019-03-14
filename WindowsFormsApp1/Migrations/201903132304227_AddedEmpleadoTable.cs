namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmpleadoTable : DbMigration
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
                        Tanda = c.String(),
                        FechaIngreso = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Usuarios", "Cedula", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Cedula");
            DropTable("dbo.Empleadoes");
        }
    }
}
