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

namespace gestaoPagamentoDivida.onfiguration.Contract.Validators;
public class DebtValidation : AbstractValidator<Debt>
{
    public DebtValidation()
    {
        RuleFor(debt => debt.Amount).NotEmpty().GreaterThan(0).WithMessage("O valor deve ser maior que zero");
        RuleFor(Debt=>Debt.CreationDate).LessThan(DateTime.Now).WithMessage("Data Inválida");






    }

}

