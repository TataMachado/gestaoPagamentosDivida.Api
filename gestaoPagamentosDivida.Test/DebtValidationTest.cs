using gestaoPagamentoDivida.onfiguration.Contract.Validators;
using gestaoPagamentosDivida.Api.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace gestaoPagamentosDivida.Test
{
    public class DebtValidationTest
    {
        private DebtValidation validations;

        public DebtValidationTest()
        {
            validations= new DebtValidation();
        }

        [Fact]
        public void Validador_dadoUmaClasseInvalida_deveDarErro()
        {
            var request = new DebtRequest() { Amount=-10};
           var result=validations.Validate(request);
            Assert.False(result.IsValid);
        }
    }
}
