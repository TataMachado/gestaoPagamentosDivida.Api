using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Models;



namespace gestaoPagamentosDivida.Api.Requests
{
    public class DebtRequest
    {
        public decimal Amount { get; set; }

        public DebtorRequest Debtor { get; set; }
        public DateTime CreationDate { get; set; }
        public string DueDate { get; set; }
        
        public Guid Id { get; set; }

        public DebtRequest()
        {
            Id= Guid.NewGuid();
        }
    }
   
}