using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DAL.MODEL;

namespace DAL.MAPPING
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(c => c.Id);
            Property(c => c.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasKey(x => x.Id)
            //.Property(x => x.Id)
            //.HasColumnName("id")
            //.IsRequired()
            //.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasMany(p => p.AtendimentoX)
            //.WithOptional();  // Permite que o codigo do cliente fique zerado na tabela de atendimento
            .WithRequired(p => p.ClienteX)
            .HasForeignKey(p => p.ClienteId);
        }
    }
}

