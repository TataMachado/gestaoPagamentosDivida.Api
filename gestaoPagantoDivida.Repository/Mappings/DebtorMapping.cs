using gestaoPagamentoDivida.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagantoDivida.Repository.Mappings
{
    public class DebtorMapping : IEntityTypeConfiguration<Debtor>
    {
        public void Configure(EntityTypeBuilder<Debtor> builder)
        {
            builder.ToTable(name: nameof(Debtor));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("string");
            builder.Property(x=>x.Document).HasColumnType("string");
            builder.HasOne(x => x.Debt).WithOne(x=>x.Debtor)
                .HasForeignKey<Debtor>(x=>x.Id)
                .HasConstraintName("FKDebtId");
        }
    }
}
