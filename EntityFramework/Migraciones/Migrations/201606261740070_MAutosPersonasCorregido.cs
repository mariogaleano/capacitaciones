namespace Migraciones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MAutosPersonasCorregido : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Automovil", "Persona_PersonaId", "dbo.Persona");
            DropIndex("dbo.Automovil", new[] { "Persona_PersonaId" });
            RenameColumn(table: "dbo.Automovil", name: "Persona_PersonaId", newName: "PersonaId");
            AlterColumn("dbo.Automovil", "PersonaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Automovil", "PersonaId");
            AddForeignKey("dbo.Automovil", "PersonaId", "dbo.Persona", "PersonaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Automovil", "PersonaId", "dbo.Persona");
            DropIndex("dbo.Automovil", new[] { "PersonaId" });
            AlterColumn("dbo.Automovil", "PersonaId", c => c.Int());
            RenameColumn(table: "dbo.Automovil", name: "PersonaId", newName: "Persona_PersonaId");
            CreateIndex("dbo.Automovil", "Persona_PersonaId");
            AddForeignKey("dbo.Automovil", "Persona_PersonaId", "dbo.Persona", "PersonaId");
        }
    }
}
