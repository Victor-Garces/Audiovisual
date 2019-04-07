namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRentaDevoluciones : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RentaDevoluciones", "FechaPrestamo", c => c.DateTime());
            AlterColumn("dbo.RentaDevoluciones", "FechaDevolucion", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RentaDevoluciones", "FechaDevolucion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.RentaDevoluciones", "FechaPrestamo", c => c.DateTime(nullable: false));
        }
    }
}
