using FluentValidation;
using gestaoPagamentoDivida.Domain.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagamentoDivida.Domain.Models.Validators
{
    public class PaymentValidation: AbstractValidator<Payment>
    {
        public PaymentValidation()
        {
            RuleFor(payment => payment.Amount_payment).NotEmpty().GreaterThan(0).WithMessage("O valor deve ser maior que zero");
            RuleFor(payment => payment.Payment_date).LessThan(DateTime.Now).WithMessage("Data Inválida");






        }
    }
}
