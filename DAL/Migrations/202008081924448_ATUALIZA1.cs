namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ATUALIZA1 : DbMigration
    {
        public override void Up()
        {
         
        }
        
        public override void Down()
        {
            AddColumn("dbo.Solicitante", "ClienteId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Solicitante", "FilialId", "dbo.Filial");
            DropForeignKey("dbo.Filial", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Solicitante", new[] { "FilialId" });
            DropIndex("dbo.Filial", new[] { "ClienteId" });
            DropColumn("dbo.Solicitante", "FilialId");
            DropTable("dbo.Filial");
            CreateIndex("dbo.Solicitante", "ClienteId");
            AddForeignKey("dbo.Solicitante", "ClienteId", "dbo.Cliente", "Id", cascadeDelete: true);
        }
    }
}
