namespace Migraciones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MPersonaCamposRequeridos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Persona", "Nombre", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.Persona", "Apellido", c => c.String(nullable: false, maxLength: 120));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persona", "Apellido", c => c.String(maxLength: 120));
            AlterColumn("dbo.Persona", "Nombre", c => c.String(maxLength: 120));
        }
    }
}
