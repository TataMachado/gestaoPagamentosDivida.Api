using gestaoPagamentoDivida.Domain.Contracts;
using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentoDivida.Domain.Models;

namespace gestaoPagamentosDivida.Domain.Contracts

{
    public class DebtContract
    {
        public decimal Amount { get; set; }
       
       public DebtorContract Debtor { get; set; }
        public PaymentContract Payment { get; set; }

        

        
        public DateTime DueDate { get; set; }

       
    
    }
}
