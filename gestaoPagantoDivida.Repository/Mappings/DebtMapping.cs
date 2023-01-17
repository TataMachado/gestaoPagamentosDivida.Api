using gestaoPagamentoDivida.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagantoDivida.Repository.Mappings
{
    public class DebtMapping : IEntityTypeConfiguration<Debt>
    {
        public void Configure(EntityTypeBuilder<Debt> builder)

        {
            builder.ToTable(nameof(Debt));
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Amount).HasColumnType("decimal");
            builder.Property(x=>x.DueDate).HasColumnType("dateTime2(7)");
            builder.Property(x => x.CreationDate).HasColumnType("dateTime2(7)");
            builder.HasOne(x => x.Debtor).WithOne(x=>x.Debt);
            builder.HasMany(x=>x.Payments).WithOne(x=>x.Debt);
         
            

        }
    }
}
