using gestaoPagamentosDivida.Api.Requests;

namespace gestaoPagametosDivida.Test
{
    public class DebtValidation
    {
        private DebtValidation validations;
        public DebtValidation()
        {
            validations = new DebtValidation();
        }
        [Fact]
        public void Validador_dadoUmaClasseInvalida_deveDarErro()
        {
            var request = new DebtRequest() { Amount = -10 };
           //var result=validations.Validate(request);
           // Assert.False(result.IsValid);
        }

    }
}