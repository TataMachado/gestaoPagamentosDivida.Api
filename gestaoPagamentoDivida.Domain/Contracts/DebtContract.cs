using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentoDivida.Domain.Models;

namespace gestaoPagamentosDivida.Domain.Contracts

{
    public class DebtContract
    {
        public decimal Amount { get; set; }
       
       public Debt debt;

        public DebtContract(Debt debt)
        {
            debt = debt;
        }

        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }

        public Guid Id { get; set; }
        public DebtContract()
       {

        }
    
    }
}
