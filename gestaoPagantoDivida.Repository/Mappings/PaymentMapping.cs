using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.entitys;
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
    public class PaymentMapping : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable(nameof(Payment));
            builder.HasKey(x => x.Id);  
            builder.Property(x=>x.Amount_payment).HasColumnType("decimal");
            builder.Property(x => x.Date_payment).HasColumnType("dateTime2(7)");
            builder.HasOne(x => x.Debt).WithMany(x => x.Payments);

        }
    }
}
