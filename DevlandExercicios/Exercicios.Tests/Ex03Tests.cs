using Xunit;
using Exercicios;

namespace Exercicios.Tests
{
    public class Exercicio03Tests
    {
        [Fact]
        public void VerificarNumeroPrimo_NumeroPrimo()
        {
            // Arrange
            Ex03 ex03 = new Ex03();
            int numero = 7;

            // Act
            string resultado = ex03.VerificarNumeroPrimo(numero);

            // Assert
            Assert.Equal("É um número primo!", resultado);
        }

        [Fact]
        public void VerificarNumeroPrimo_NumeroNaoPrimo()
        {
            // Arrange
            Ex03 ex03 = new Ex03();
            int numero = 4;

            // Act
            string resultado = ex03.VerificarNumeroPrimo(numero);

            // Assert
            Assert.Equal("Não é um número primo!", resultado);
        }

        [Fact]
        public void VerificarNumeroPrimo_NumeroIgualUm()
        {
            // Arrange
            Ex03 ex03 = new Ex03();
            int numero = 1;

            // Act
            string resultado = ex03.VerificarNumeroPrimo(numero);

            // Assert
            Assert.Equal("Não é um número primo!", resultado);
        }

        [Fact]
        public void VerificarNumeroPrimo_NumeroZero()
        {
            // Arrange
            Ex03 ex03 = new Ex03();
            int numero = 0;

            // Act
            string resultado = ex03.VerificarNumeroPrimo(numero);

            // Assert
            Assert.Equal("Não é um número primo!", resultado);
        }
    }
}
