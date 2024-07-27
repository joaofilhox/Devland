using Xunit;
using Exercicios;

namespace Exercicios.Tests
{
    public class Exercicio05Tests
    {
        [Fact]
        public void OrdenacaoDeArray_ArrayDesordenado()
        {
            // Arrange
            Ex05 ex05 = new Ex05();
            int[] input = { 5, 2, 9, 1, 5, 6 };

            // Act
            int[] resultado = ex05.OrdenacaoDeArray(input);

            // Assert
            Assert.Equal(new int[] { 1, 2, 5, 5, 6, 9 }, resultado);
        }

        [Fact]
        public void OrdenacaoDeArray_ArrayJaOrdenado()
        {
            // Arrange
            Ex05 ex05 = new Ex05();
            int[] input = { 1, 2, 3, 4, 5 };

            // Act
            int[] resultado = ex05.OrdenacaoDeArray(input);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, resultado);
        }

        [Fact]
        public void OrdenacaoDeArray_ArrayComElementosIguais()
        {
            // Arrange
            Ex05 ex05 = new Ex05();
            int[] input = { 4, 4, 4, 4 };

            // Act
            int[] resultado = ex05.OrdenacaoDeArray(input);

            // Assert
            Assert.Equal(new int[] { 4, 4, 4, 4 }, resultado);
        }

        [Fact]
        public void OrdenacaoDeArray_ArrayVazio()
        {
            // Arrange
            Ex05 ex05 = new Ex05();
            int[] input = { };

            // Act
            int[] resultado = ex05.OrdenacaoDeArray(input);

            // Assert
            Assert.Equal(new int[] { }, resultado);
        }

        [Fact]
        public void OrdenacaoDeArray_ArrayComUmElemento()
        {
            // Arrange
            Ex05 ex05 = new Ex05();
            int[] input = { 42 };

            // Act
            int[] resultado = ex05.OrdenacaoDeArray(input);

            // Assert
            Assert.Equal(new int[] { 42 }, resultado);
        }
    }
}
