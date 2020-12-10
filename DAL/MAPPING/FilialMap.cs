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
    public class FilialMap : EntityTypeConfiguration<Filial>
    {
        public FilialMap()
        {
            ToTable("Filial");
            HasKey(c => c.Id);
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.ClienteId)
                .IsRequired();

            HasRequired(x => x.ClienteX)
                .WithMany(x => x.FilialX)
                .HasForeignKey(c => c.ClienteId);
        }
    }
}

