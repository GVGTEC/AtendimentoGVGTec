namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Atendimento", "NomeSolicitante", c => c.String());
            AddColumn("dbo.Atendimento", "Observacao", c => c.String());
            AddColumn("dbo.Atendimento", "TempoServico", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Atendimento", "TempoServico");
            DropColumn("dbo.Atendimento", "Observacao");
            DropColumn("dbo.Atendimento", "NomeSolicitante");
        }
    }
}
