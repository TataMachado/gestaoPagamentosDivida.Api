using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain;
using gestaoPagamentoDivida.Domain.Repository;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagantoDivida.Repository
{
    public class RepositoryDebt : RepositoryEntity<Debt>, IRepositoryDebt
    {
        private readonly SqlDatabaseContext _sqlDatabaseContext;
        private Guid Id;

        public RepositoryDebt(SqlDatabaseContext sqlDatabaseContext) : base(sqlDatabaseContext)

        {

            this._sqlDatabaseContext = sqlDatabaseContext;
        }

      
        List<Debt> IRepositoryDebt .GetAll()
        {
            return _sqlDatabaseContext.Debts.ToList();
        }

       public Debt GetAll(Guid Id )
        {
            return _sqlDatabaseContext.Debts.FirstOrDefault(x => x.Id == Id);
        }

        public List<Debt> DeleteDebitsId(Guid id)
        {
            return _sqlDatabaseContext.Debts.Where(x => x.Id == id).ToList();
        }

        
    }
}
