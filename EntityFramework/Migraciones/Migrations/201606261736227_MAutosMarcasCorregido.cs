namespace Migraciones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MAutosMarcasCorregido : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Automovil", "Marca_MarcaId", "dbo.Marca");
            DropIndex("dbo.Automovil", new[] { "Marca_MarcaId" });
            RenameColumn(table: "dbo.Automovil", name: "Marca_MarcaId", newName: "MarcaId");
            AlterColumn("dbo.Automovil", "MarcaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Automovil", "MarcaId");
            AddForeignKey("dbo.Automovil", "MarcaId", "dbo.Marca", "MarcaId", cascadeDelete: true);
            DropColumn("dbo.Automovil", "MacraId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Automovil", "MacraId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Automovil", "MarcaId", "dbo.Marca");
            DropIndex("dbo.Automovil", new[] { "MarcaId" });
            AlterColumn("dbo.Automovil", "MarcaId", c => c.Int());
            RenameColumn(table: "dbo.Automovil", name: "MarcaId", newName: "Marca_MarcaId");
            CreateIndex("dbo.Automovil", "Marca_MarcaId");
            AddForeignKey("dbo.Automovil", "Marca_MarcaId", "dbo.Marca", "MarcaId");
        }
    }
}
