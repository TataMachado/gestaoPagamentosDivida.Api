using FluentValidation;
using gestaoPagamentosDivida.Api.Requests;

namespace gestaoPagamentosDivida.Api.Validator
{
    public class PaymentValidation: AbstractValidator<PaymentRequest>
    {
        public PaymentValidation()
        {
            RuleFor(payment=>payment.Amount_payment).NotEmpty().WithMessage("O numéro precisa ser maior que zero");
        }
    }
}
