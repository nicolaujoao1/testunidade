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
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(4, 4);
            //Assert
            Assert.Equal(8, resultado);
        }
    }
}
