using gestaoPagamentoDivida.Domain.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagamentoDivida.Domain.Repository.Interfaces
{
    public interface IRepositoryPayment : IRepositoryEntity<Payment>
    {
        public List<Payment> GetAll();
        public Task<Payment> GetPayment(Guid Id);
        public Task<Payment> DeleteId(Guid Id);
    }
}
