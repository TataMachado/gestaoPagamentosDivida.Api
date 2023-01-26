using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;



namespace gestaoDividasApi.Test.DebtorValidationTest
{
    public class DebtorValidationTest
    {
        private DebtorValidationTest validationTest;

        public DebtorValidationTest() { 
            validationTest = new DebtorValidationTest(new Mock<IRepositoryDebt>);
        }

    }
}
