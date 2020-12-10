namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ATUALIZA2 : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Solicitante", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Solicitante", new[] { "ClienteId" });
            DropColumn("dbo.Solicitante", "ClienteId");
        }
    }
}
