namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ATUALIZA1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Atendimento", "ClienteX_Id", "dbo.Cliente");
            DropForeignKey("dbo.Atendimento", "Cliente_Id", "dbo.Cliente");
            DropIndex("dbo.Atendimento", new[] { "Cliente_Id" });
            DropIndex("dbo.Atendimento", new[] { "ClienteX_Id" });
            //DropColumn("dbo.Atendimento", "ClienteId");
            //DropColumn("dbo.Atendimento", "ClienteId");
            //RenameColumn(table: "dbo.Atendimento", name: "ClienteX_Id", newName: "ClienteId");
            //RenameColumn(table: "dbo.Atendimento", name: "Cliente_Id", newName: "ClienteId");
            //AlterColumn("dbo.Atendimento", "ClienteId", c => c.Int(nullable: false));
            AlterColumn("dbo.Atendimento", "ClienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Atendimento", "ClienteId");
            AddForeignKey("dbo.Atendimento", "ClienteId", "dbo.Cliente", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Atendimento", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Atendimento", new[] { "ClienteId" });
            AlterColumn("dbo.Atendimento", "ClienteId", c => c.Int());
            AlterColumn("dbo.Atendimento", "ClienteId", c => c.Int());
            RenameColumn(table: "dbo.Atendimento", name: "ClienteId", newName: "Cliente_Id");
            RenameColumn(table: "dbo.Atendimento", name: "ClienteId", newName: "ClienteX_Id");
            AddColumn("dbo.Atendimento", "ClienteId", c => c.Int(nullable: false));
            AddColumn("dbo.Atendimento", "ClienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Atendimento", "ClienteX_Id");
            CreateIndex("dbo.Atendimento", "Cliente_Id");
            AddForeignKey("dbo.Atendimento", "Cliente_Id", "dbo.Cliente", "Id");
            AddForeignKey("dbo.Atendimento", "ClienteX_Id", "dbo.Cliente", "Id");
        }
    }
}
