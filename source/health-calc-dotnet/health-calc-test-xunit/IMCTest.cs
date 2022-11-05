
using Xunit;

using health_calc_pack_dotnet;

namespace health_calc_test_xunit
{
    public class IMCTest 
    {
        [Fact]
        public void When_RequestIMCCalcWithValidData_ThenReturnIMCIndex()
        {
            //Arrange
            var Imc = new IMC();
            var Heigth = 1.68;
            var Weigth = 85;
            var Expected = 30.12;

            //Act
            var Result = Imc.CalcularIMC(Heigth, Weigth);

            //Assert
            Assert.Equal(Expected, Result);
        }
    }
}
