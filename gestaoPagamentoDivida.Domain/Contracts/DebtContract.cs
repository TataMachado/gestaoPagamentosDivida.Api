using gestaoPagamentoDivida.Domain.Models;

namespace gestaoPagamentosDivida.Domain.Contracts

{
    public class DebtContract
    {
        public decimal Amount { get; set; }
       
        public DebtorContract Debtor;
        public DateTime DueDate { get; set; }
        public DebtContract()
        {

        }
    
    }
}
