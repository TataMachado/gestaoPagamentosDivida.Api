using FluentValidation.Validators;
using gestaoPagamentoDivida.Domain.entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentosDivida.Domain.Contracts;

namespace gestaoPagamentoDivida.Domain.Models.Validators;

public class DebtValidation : AbstractValidator<gestaoPagamentosDivida.Domain.Contracts.DebtContract>
{
    public DebtValidation()
    {
        RuleFor(debt => debt.Amount).NotEmpty().GreaterThan(0).WithMessage("O valor deve ser maior que zero");
        RuleFor(debt => debt.Debtor.Name).Empty().WithMessage("O nome não pode estar vázio ");
        RuleFor(debt => debt.Debtor.Document).Empty().WithMessage("O documento não pode estar vázio ");
        RuleFor(debt => debt.DueDate).LessThan(DateTime.Now).WithMessage("Data Inválida");






    }

    public object ValidateAndThrowAsync(Debt debt1)
   {
       throw new NotImplementedException();
    }
}

