namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        NomeFantasia = c.String(),
                        Pessoa = c.String(),
                        CGC = c.String(),
                        CPF = c.String(),
                        IE = c.String(),
                        RG = c.String(),
                        Endereco = c.String(),
                        NumeroEnd = c.Int(nullable: false),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        CEP = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        Contato = c.String(),
                        DataCadastro = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Atendimento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Descricao = c.String(),
                        CobrarServico = c.String(),
                        ValorServico = c.Double(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        ClienteX_Id = c.Int(),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteX_Id)
                .ForeignKey("dbo.Cliente", t => t.Cliente_Id)
                .Index(t => t.ClienteX_Id)
                .Index(t => t.Cliente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Atendimento", "Cliente_Id", "dbo.Cliente");
            DropForeignKey("dbo.Atendimento", "ClienteX_Id", "dbo.Cliente");
            DropIndex("dbo.Atendimento", new[] { "Cliente_Id" });
            DropIndex("dbo.Atendimento", new[] { "ClienteX_Id" });
            DropTable("dbo.Atendimento");
            DropTable("dbo.Cliente");
        }
    }
}
