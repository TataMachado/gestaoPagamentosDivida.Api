using FluentValidation;
using gestaoPagamentoDivida.Domain.Models;
using gestaoPagamentosDivida.Api.Requests;

namespace gestaoPagamentosDivida.Api.Validator
{
    public class DebtorValidation: AbstractValidator<Debtor>
    {
        DebtorValidation() {
            RuleFor(debtor => debtor.Name).NotEmpty().MinimumLength(4).WithMessage("O nome não pode se nulo").MinimumLength(5);
            RuleFor(debtor => debtor.Document).NotEmpty().WithMessage("O documento não pode ser nulo");

        }

        public object Validate(DebtorRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
