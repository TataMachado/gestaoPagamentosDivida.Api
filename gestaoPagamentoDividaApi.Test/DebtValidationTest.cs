using gestaoPagamentoDivida.onfiguration.Contract.Validators;
using gestaoPagamentosDivida.Api.Requests;

namespace gestaoPagamentoDividaApi.Test
{
    public class DebtValidationTest
    {


        private DebtValidation validations;

        public DebtValidationTest()
        {
            validations = new DebtValidation();
        }

        [Fact]
        public void Validador_dadoUmaClasseInvalida_deveDarErro()
        {
            var request = new DebtRequest() { Amount = -10, DueDate= ""};
            var result = validations.Validate(request);
            Assert.False(result.IsValid);
        }
        [Fact]
        public void Validador_dadoUmaClasseValida_deveDarSucesso()
        {
            var request = new DebtRequest() { Amount=10, DueDate = "30102023" };
            var result = validations.Validate(request);
            Assert.True(result.IsValid);
        }
        
    }
}