using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentoDivida.Domain.Repository;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagantoDivida.Repository
{
    public class RepositoryDebt: RepositoryEntity<Debt>, IRepositoryDebt
    {
        private readonly SqlDatabaseContext _sqlDatabaseContext;
        public RepositoryDebt(SqlDatabaseContext sqlDatabaseContext) : base(sqlDatabaseContext)

        {

            _sqlDatabaseContext= sqlDatabaseContext;
        }

       
    } 
}
