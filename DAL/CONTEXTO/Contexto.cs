using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;
using DAL.MODEL;
using DAL.MAPPING;
using MySql.Data.Entity;

namespace DAL.Contexto
{
    //Code-Based Configuration and Dependency resolution
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class BancoContexto : DbContext
    {
        public BancoContexto() : base("name=CONEXAO")
       {
            // SE HABILITADA ESTÁ LINHA QUANDO FEITO O PRIMEIRO ACESSO
            // NO SERVIDOR DAVA ERRO DE LAZYLOAD. TENTAR HABILITAR AGORA
            // QUE O BANCO JÁ ESTÁ CRIADO
            //this.Configuration.LazyLoadingEnabled = true;

            Database.SetInitializer<BancoContexto>(new CreateDatabaseIfNotExists<BancoContexto>());
        }

        public DbSet<Cliente> ClienteCtx { get; set; }
        public DbSet<Atendimento> AtendimentoCtx { get; set; }
        public DbSet<Solicitante> SolicitanteCtx { get; set; }
        public DbSet<Atendente> AtendenteCtx { get; set; }
        public DbSet<Filial> FilialCtx { get; set; }
        public DbSet<Teste> TesteCtx { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2")); // NAO FUNCIONA PARA MYSQL SOMENTE PARA SQLSERVER

            //Database.SetInitializer(new SQLite.CodeFirst.SqliteCreateDatabaseIfNotExists<BancoContexto>(modelBuilder));

            //Database.SetInitializer(new SQLite.CodeFirst.SqliteCreateDatabaseIfNotExists<BancoContexto>(modelBuilder));

            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new AtendimentoMap());
            modelBuilder.Configurations.Add(new SolicitanteMap());
            modelBuilder.Configurations.Add(new AtendenteMap());

            base.OnModelCreating(modelBuilder);
        }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //Mapeamento para a tabela Cliente
        //    //S1: Chave Primária para a tabela Cliente
        //    modelBuilder.Entity<Cliente>().HasKey(c => c.ClienteId);
        //    //S2: A chave Identity Key para ClienteId
        //    modelBuilder.Entity<Cliente>().Property(c => c.ClienteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        //    // tamanho máximo para as propriedades Nome,Endereco,Telefone e Cidade
        //    modelBuilder.Entity<Cliente>().Property(c => c.Nome).HasMaxLength(80);
        //    modelBuilder.Entity<Cliente>().Property(c => c.Endereco).HasMaxLength(100);
        //    modelBuilder.Entity<Cliente>().Property(c => c.Telefone).HasMaxLength(20);
        //    modelBuilder.Entity<Cliente>().Property(c => c.Cidade).HasMaxLength(50);
        //    //Mapeamento para a tabela Pedido
        //    //S1: Chave Primaria para a tabela Pedido
        //    modelBuilder.Entity<Pedido>().HasKey(p => p.PedidoId);
        //    //S2: Uma chave identity para o PedidoId
        //    modelBuilder.Entity<Pedido>().Property(p => p.PedidoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        //    //S2: O tamanho máximo para o item
        //    modelBuilder.Entity<Pedido>().Property(p => p.Item).HasMaxLength(50);
        //    //S3: A chave estrangeira para a tabela Pedido - ClienteId
        //    modelBuilder.Entity<Pedido>().HasRequired(c => c.Cliente).WithMany(p => p.Pedidos).HasForeignKey(p => p.ClienteId);
        //    // A deleção em cascata a partir de Cliente para Pedidos
        //    modelBuilder.Entity<Pedido>()
        //        .HasRequired(c => c.Cliente)
        //        .WithMany(p => p.Pedidos)
        //        .HasForeignKey(p => p.ClienteId)
        //        .WillCascadeOnDelete(true);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
