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
    public class AtendimentoMap : EntityTypeConfiguration<Atendimento>
    {
        public AtendimentoMap()
        {
            ToTable("Atendimento");
            HasKey(c => c.Id);
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.ClienteId)
                .IsRequired();

            HasRequired(x => x.ClienteX)
                .WithMany(x => x.AtendimentoX)
                .HasForeignKey(c => c.ClienteId);

            Property(p => p.AtendenteId)
                .IsRequired();

            HasRequired(x => x.AtendenteX)
                .WithMany(x => x.AtendimentoX)
                .HasForeignKey(c => c.AtendenteId);
        }
    }
}

