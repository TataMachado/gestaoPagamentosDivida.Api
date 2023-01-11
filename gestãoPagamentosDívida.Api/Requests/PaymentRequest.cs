using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Models;

namespace gestaoPagamentosDivida.Api.Requests
{
    public class PaymentRequest
    {
        public decimal Amount_payment { get; set; }
        public DateTime Date_payment { get; set; }
        public DebtorRequest Debtor { get; set; }
        public Guid Id { get; set; }
        public PaymentRequest()
        {
            Id= Guid.NewGuid();
        }
    }
}
