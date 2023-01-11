﻿using FluentValidation.Validators;
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
using gestaoPagamentosDivida.Domain.Contracts;

namespace gestaoPagamentoDivida.Domain.Models.Validators;

public class DebtorValidation : AbstractValidator<DebtorContract>
{
    public DebtorValidation()
    {
        RuleFor(debtor => debtor.Name).NotEmpty().MinimumLength(3).WithMessage("O nome não pode ser nulo");
        RuleFor(debtor => debtor.Document).NotEmpty().MinimumLength(3).WithMessage("O docuento não pode ser nulo");
        RuleFor(debtor => debtor.Payment.Amount_payment).NotEmpty().LessThan(0).WithMessage("O valor não pode ser zero");
        RuleFor(debtor => debtor.Payment.Date_payment).LessThan(DateTime.Now).WithMessage("Data inválida");

        
        







    }

}

