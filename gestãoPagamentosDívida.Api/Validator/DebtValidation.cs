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
            RuleFor(debt => debt.Debtor).NotEmpty().SetValidator(new DebtorValidation()) ;


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

       

       

        int IComparable<DebtRequest>.CompareTo(DebtRequest? debt)
        {
            return debt.Amount.CompareTo(debt.Amount);
        }
    }

}

