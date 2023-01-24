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
            return _sqlDatabaseContext.Debts.Include(x=>x.Debtor).Include(x=>x.Payments). ToList();


        }

        public Task<Debt> GetAll(Guid Id)
        {
            return _sqlDatabaseContext.Debts.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public Task <Debt> DeleteDebitsId(Guid Id)
        {
            var debt= _sqlDatabaseContext.Debts.Where(x => x.Id == Id).FirstOrDefaultAsync(x=>x.Id==Id).Result;
            _sqlDatabaseContext.Debts.Remove(debt);
            _sqlDatabaseContext.SaveChanges();
            return Task.FromResult(debt);
                 }  
        public List<Debt> GetId(Guid Id)
        {

            return _sqlDatabaseContext.Debts.Where(x => x.Id == Id).ToList();
        }
    }
    }
