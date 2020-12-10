namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ATUALIZA2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Solicitante",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Solicitante", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Solicitante", new[] { "ClienteId" });
            DropTable("dbo.Solicitante");
        }
    }
}
