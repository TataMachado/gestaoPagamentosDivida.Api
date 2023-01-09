using gestaoPagamentoDivida.Domain.entity;

namespace gestaoPagamentosDivida.Api.Requests
{
    public class PaymentRequest
    {
        public decimal Amount_payment { get; set; }
        public DateTime Date_payment { get; set; }

    }
}
