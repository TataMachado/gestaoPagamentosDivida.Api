using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagantoDivida.Repository.Mappings
{
    public class RepositoryPayment : RepositoryEntity<Payment>, IRepositoryPayment
    {
        public RepositoryPayment(SqlDatabaseContext sqlDatabaseContext) : base(sqlDatabaseContext)
        {
        }
    }
}
