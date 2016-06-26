namespace Migraciones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionPersonasPK : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Persona");
            AlterColumn("dbo.Persona", "PersonaId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Persona", "PersonaId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Persona");
            AlterColumn("dbo.Persona", "PersonaId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Persona", "PersonaId");
        }
    }
}
