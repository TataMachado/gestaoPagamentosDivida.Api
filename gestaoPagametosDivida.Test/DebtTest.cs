using AutoFixture;
using gestaoPagamentoDivida.Domain;
using gestaoPagamentosDivida.Api.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagametosDivida.Test
{
    public class DebtTest
    {
        public DebtTest() { 
            
        }
        private Debt validations = new();
        private DebtValidation valitionsDebt = new();
        private readonly Fixture _fixture = new();
        [Fact]
        public void CacularDivida_dadoUmValorPositivo_deveDarSucesso()
        {
            var debt = new Debt() { Amount = 10 };

            var resultadoEsperado = 5;
            var valorPagamento = 5;

             debt.CalcularDivida(valorPagamento);
            Assert.Equal(resultadoEsperado, debt.Amount);
        }
    }
   
}

