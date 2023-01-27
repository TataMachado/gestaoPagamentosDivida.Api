
using AutoFixture;
using gestaoPagamentosDivida.Api.Requests;
using gestaoPagamentosDivida.Api.Validator;

namespace gestaoPagametosDivida.Test
{
    public class DebtValidationTest
    {
        private DebtValidation validations = new();
        private readonly Fixture _fixture = new();


        [Fact]
        public void Validador_dadoUmAmountInvalida_deveDarErro()
        {
            var request = _fixture.Build<DebtRequest>()
                .With(x => x.Amount,0)
                .Create();

            var result = validations.Validate(request);
            Assert.False(result.IsValid);
        }


        [Fact]
        public void Validador_dadoUmaAmountValida_deveDarSucesso()
        {
            var request = _fixture.Build<DebtRequest>()
          .With(x => x.Amount, 10)
          .Create();
            var result = validations.Validate(request);
            Assert.True(result.IsValid);

        }
    }
}
