using Xunit;
using Exercicios;

namespace Exercicios.Tests
{
    public class Ex02Tests
    {
        [Fact]
        public void VerificarSeNumeroParOuImpar_NumeroPar()
        {
            // Arrange
            Ex02 ex02 = new Ex02();
            int numero = 4;

            // Act
            string resultado = ex02.VerificarSeNumeroParOuImpar(numero);

            // Assert
            Assert.Equal("O número é par", resultado);
        }

        [Fact]
        public void VerificarSeNumeroParOuImpar_NumeroImpar()
        {
            // Arrange
            Ex02 ex02 = new Ex02();
            int numero = 5;

            // Act
            string resultado = ex02.VerificarSeNumeroParOuImpar(numero);

            // Assert
            Assert.Equal("O número é ímpar", resultado);
        }

        [Fact]
        public void VerificarSeNumeroParOuImpar_Zero()
        {
            // Arrange
            Ex02 ex02 = new Ex02();
            int numero = 0;

            // Act
            string resultado = ex02.VerificarSeNumeroParOuImpar(numero);

            // Assert
            Assert.Equal("O número é par", resultado);
        }
    }
}
