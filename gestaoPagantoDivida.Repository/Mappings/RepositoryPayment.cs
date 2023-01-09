using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagantoDivida.Repository.Mappings
{
    public class RepositoryPayment : RepositoryEntity<Payment>, IRepositoryPayment
    {
        private readonly SqlDatabaseContext _sqlDatabaseContext;
        public RepositoryPayment(SqlDatabaseContext sqlDatabaseContext) : base(sqlDatabaseContext)
        {
            this._sqlDatabaseContext = sqlDatabaseContext;
        }


        public List<Payment> GetAll()
        {
            return _sqlDatabaseContext.Payment.ToList();
        }
      public  Payment GetAllId(Guid Id)
        {
            return _sqlDatabaseContext.Payment.Where(x => x.Id == Id).FirstOrDefault();
        }

    }
}
