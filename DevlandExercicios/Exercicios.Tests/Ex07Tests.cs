using Xunit;
using Exercicios;

namespace Exercicios.Tests
{
    public class Exercicio07Tests
    {
        [Fact]
        public void MaiorElementoDoArray_ComVariosNumeros()
        {
            // Arrange
            Ex07 ex07 = new Ex07();
            int[] numeros = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 };

            // Act
            int resultado = ex07.MaiorElementoDoArray(numeros);

            // Assert
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void MaiorElementoDoArray_ComNumerosNegativos()
        {
            // Arrange
            Ex07 ex07 = new Ex07();
            int[] numeros = { -1, -3, -5, -7, -9, -2, -4, -6, -8, 0 };

            // Act
            int resultado = ex07.MaiorElementoDoArray(numeros);

            // Assert
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void MaiorElementoDoArray_ComElementosRepetidos()
        {
            // Arrange
            Ex07 ex07 = new Ex07();
            int[] numeros = { 1, 2, 3, 3, 2, 1 };

            // Act
            int resultado = ex07.MaiorElementoDoArray(numeros);

            // Assert
            Assert.Equal(3, resultado);
        }

        [Fact]
        public void MaiorElementoDoArray_ComUmElemento()
        {
            // Arrange
            Ex07 ex07 = new Ex07();
            int[] numeros = { 42 };

            // Act
            int resultado = ex07.MaiorElementoDoArray(numeros);

            // Assert
            Assert.Equal(42, resultado);
        }
    }
}
