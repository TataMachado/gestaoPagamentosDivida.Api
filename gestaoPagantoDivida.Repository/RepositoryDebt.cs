using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.entitys;
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

            _sqlDatabaseContext = sqlDatabaseContext;
        }

        //public Task ValidateAndThrowAsync(Debt debt, object debt1)
       // {
           // return _sqlDatabaseContext.AddRangeAsync(debt, debt1);
       // }

        List<Debt> IRepositoryDebt .GetAll()
        {
            return _sqlDatabaseContext.Debt.Include(x => x.Debtor).ToList();
        }

       public IRepositoryDebt GetAll(Guid Id )
        {
            return (IRepositoryDebt)_sqlDatabaseContext.Debt.Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<Debt> DeleteDebitsId(Guid id)
        {
            return _sqlDatabaseContext.Debt.Where(x => x.Id == id).ToList();
        }

        public Task ValidateAndThrowAsync(Debt debt, object debt1)
        {
            throw new NotImplementedException();
        }
    }
}
