using LeilaoOnline.Core;

namespace LeilaoOnline.Tests
{
    public class LanceCtor
    {
        [Fact]
        public void LancaArgumentExceptionDadoValorNegativo()
        {
            //Arrange - cenário
            var valorNegativo = -100;

        //Assert
        Assert.Throws<System.ArgumentException>(

            //Act
            () => new Lance(null!, valorNegativo)
        );
        }

    }
}
