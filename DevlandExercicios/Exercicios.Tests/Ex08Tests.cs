using Xunit;
using Exercicios;

namespace Exercicios.Tests
{
    public class Exercicio08Tests
    {
        [Fact]
        public void SomaDosElementosDoArray_ComVariosNumeros()
        {
            // Arrange
            Ex08 ex08 = new Ex08();
            int[] numeros = { 1, 2, 3, 4, 5 };

            // Act
            int resultado = ex08.SomaDosElementosDoArray(numeros);

            // Assert
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void SomaDosElementosDoArray_ComNumerosNegativos()
        {
            // Arrange
            Ex08 ex08 = new Ex08();
            int[] numeros = { -1, -2, -3, -4, -5 };

            // Act
            int resultado = ex08.SomaDosElementosDoArray(numeros);

            // Assert
            Assert.Equal(-15, resultado);
        }

        [Fact]
        public void SomaDosElementosDoArray_ComNumerosPositivosENegativos()
        {
            // Arrange
            Ex08 ex08 = new Ex08();
            int[] numeros = { 1, -2, 3, -4, 5 };

            // Act
            int resultado = ex08.SomaDosElementosDoArray(numeros);

            // Assert
            Assert.Equal(3, resultado);
        }

        [Fact]
        public void SomaDosElementosDoArray_ArrayVazio()
        {
            // Arrange
            Ex08 ex08 = new Ex08();
            int[] numeros = { };

            // Act
            int resultado = ex08.SomaDosElementosDoArray(numeros);

            // Assert
            Assert.Equal(0, resultado);
        }
    }
}
