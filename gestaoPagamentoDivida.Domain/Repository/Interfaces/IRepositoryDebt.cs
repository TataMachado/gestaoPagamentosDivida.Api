using gestaoPagamentoDivida.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagamentoDivida.Domain.Repository.Interfaces
{
    public interface IRepositoryDebt : IRepositoryEntity<Debt>
    {
        
      //  Task ValidateAndThrowAsync(Debt debt, object debt1);
        List<Debt> GetAll();
        List<Debt> DeleteDebitsId(Guid id);
        Debt GetAll(Guid Id);
    }
}
