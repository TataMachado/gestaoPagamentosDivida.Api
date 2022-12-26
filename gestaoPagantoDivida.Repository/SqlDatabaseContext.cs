using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentoDivida.Domain.Models;
using gestaoPagantoDivida.Repository;
using gestaoPagantoDivida.Repository.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagantoDivida.Repository
{
    public class SqlDatabaseContext : DbContext
    {

      
        public DbSet<gestaoPagamentoDivida.Domain.entitys.Debt> Debt { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<gestaoPagamentoDivida.Domain.Models.Debtor> Debtors { get; set; }
        public SqlDatabaseContext(DbContextOptions<SqlDatabaseContext> options):base(options) { }
        public SqlDatabaseContext() { }

        public override int SaveChanges()
{
    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Due_date") != null))
    {
        if (entry.State == EntityState.Added)
        {
            entry.Property("Due_date").CurrentValue = DateTime.Now;
        }
        if (entry.State == EntityState.Modified)
        {
            entry.Property("Due_date").IsModified = false;
        }
    }
    return base.SaveChanges();

}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DebtMapping());
            modelBuilder.ApplyConfiguration(new DebtorMapping());
            modelBuilder.ApplyConfiguration(new PaymentMapping());

        }


    }
}
