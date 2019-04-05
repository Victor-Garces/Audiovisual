namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedModelsTable : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Modeloes", "Marca_Id", "dbo.Marcas");
            DropIndex("dbo.Modeloes", new[] { "Marca_Id" });
            DropTable("dbo.Modeloes");
        }
    }
}
