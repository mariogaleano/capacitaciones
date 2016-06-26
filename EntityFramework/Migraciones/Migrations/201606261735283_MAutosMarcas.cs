namespace Migraciones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MAutosMarcas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Automovil",
                c => new
                    {
                        AutomovilId = c.Int(nullable: false, identity: true),
                        Placa = c.String(nullable: false, maxLength: 6),
                        Color = c.String(),
                        MacraId = c.Int(nullable: false),
                        Marca_MarcaId = c.Int(),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.AutomovilId)
                .ForeignKey("dbo.Marca", t => t.Marca_MarcaId)
                .ForeignKey("dbo.Persona", t => t.Persona_PersonaId)
                .Index(t => t.Marca_MarcaId)
                .Index(t => t.Persona_PersonaId);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        MarcaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MarcaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Automovil", "Persona_PersonaId", "dbo.Persona");
            DropForeignKey("dbo.Automovil", "Marca_MarcaId", "dbo.Marca");
            DropIndex("dbo.Automovil", new[] { "Persona_PersonaId" });
            DropIndex("dbo.Automovil", new[] { "Marca_MarcaId" });
            DropTable("dbo.Marca");
            DropTable("dbo.Automovil");
        }
    }
}
