using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        [Trait("Calculadora","Somar  retornar valor soma")]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(4, 4);
            //Assert
            Assert.Equal(8, resultado);
        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(3, 5, 8)]
        [InlineData(4, -1, 3)]
        [InlineData(10, 1, 11)]
        [InlineData(0, 0, 0)]
        [InlineData(5, 11, 16)]
        [Trait("Calculadora","Somar retornar valores corretos")]
        public void Calculadora_Somar_RetornarValoresCorretos(double v1, double v2, double total)
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(v1, v2);
            //Assert
            Assert.Equal(total, resultado);

        }
    }
}
