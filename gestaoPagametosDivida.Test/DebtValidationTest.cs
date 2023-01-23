

using gestaoPagamentosDivida.Api.Requests;
using gestaoPagamentosDivida.Api.Validator;

namespace gestaoPagametosDivida.Test
{
    public class DebtValidationTest
    {
        private DebtValidation validations;

        [Fact]
        public void Validador_dadoUmaClasseInvalida_deveDarErro()
        {
            var request = new DebtRequest() { Amount = 0};
            var result = validations.Validate(request);
            Assert.False(result.IsValid);

        }
      /*  [Fact]
        public void Validador_dadoUmaClasseValida_deveDarSucesso()
        {
            var request = new DebtRequest() { Amount = 10 };
            var result = validations.Validate(request);
            Assert.True(result.IsValid);
        }*/
    }
}