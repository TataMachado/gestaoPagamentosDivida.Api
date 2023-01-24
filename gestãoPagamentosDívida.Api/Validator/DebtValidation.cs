using FluentValidation;
using gestaoPagamentoDivida.Domain;
using gestaoPagamentosDivida.Api.Requests;
using System.Net;

namespace gestaoPagamentosDivida.Api.Validator
{
    public class DebtValidation : AbstractValidator<DebtRequest>, IComparable<DebtRequest>
    {
        public DebtValidation()
        {
            RuleFor(debt => debt.Amount).NotEmpty().WithMessage("O numero precisa ser maior que zero");
            RuleFor(debt => debt.Amount).GreaterThanOrEqualTo(debt => debt.Amount);
            RuleFor(debt => debt.Debtor.Name).NotEmpty().MinimumLength(4).WithMessage("O nome não pode se nulo").MinimumLength(5);
            RuleFor(debt => debt.Debtor.Document).NotEmpty().WithMessage("O documento não pode ser nulo");
        }


      
     
       
            public decimal CompareTo(DebtRequest debt)
        {
            DebtRequest request=new DebtRequest();
            debt.Amount=request.Amount;
            if (request.Amount > 0)
            {
                debt.Amount=request.Amount;
            }return debt.Amount;
        }

        public object Validate(decimal amount, string name, string document)
        {
            throw new NotImplementedException();
        }

        public object Validate(DebtorRequest request)
        {
            throw new NotImplementedException();
        }

        int IComparable<DebtRequest>.CompareTo(DebtRequest? debt)
        {
            return debt.Amount.CompareTo(debt.Amount);
        }
    }

}

