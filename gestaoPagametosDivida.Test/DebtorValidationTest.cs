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
        private DebtValidation validations = new();
        private readonly Fixture _fixture = new();

        [Fact]
        public void Validador_dadoUmNomeInavalido_deveDarErro()
        {
            var request = _fixture.Build<DebtRequest>()
                .With(x=>x.Debtor.Name, "")
                .Create();
            var result = validations.Validate(request);
            Assert.True(result.IsValid);

        }
    }
}
