using gestaoPagamentoDivida.Domain.Models;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagantoDivida.Repository
{
    public class RepositoryDebtor : RepositoryEntity<Debtor>, IRepositoryDebtor
    {
        public RepositoryDebtor(SqlDatabaseContext sqlDatabaseContext) : base(sqlDatabaseContext)
        {
        }
    }
}
