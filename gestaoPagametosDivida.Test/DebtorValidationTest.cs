using AutoFixture;
using FluentValidation;
using gestaoPagamentoDivida.Domain;
using gestaoPagamentosDivida.Api.Requests;
using gestaoPagamentosDivida.Api.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagametosDivida.Test
{
    public class DebtorValidationTest
    {
        private DebtorValidation validations = new();

        [Fact]
        public void Validador_dadoUmNomeInavalido_deveDarErro()
        {
            
                var request = new DebtorRequest() { Name = "", Document = "" };

                var result = validations.Validate(request);
            Assert.False(result.IsValid);

        }
        [Fact]
        public void Validador_dadoUmNomeaValido_deveDarSucesso()
        {
            var request = new DebtorRequest() { Name="Seu nome", Document="Documenr" };
            var result = validations.Validate(request);
            Assert.True(result.IsValid);
        }
    }
}
