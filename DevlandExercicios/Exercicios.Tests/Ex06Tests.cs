using Xunit;
using Exercicios;
using System.Text.RegularExpressions;

namespace Exercicios.Tests
{
    public class Exercicio06Tests
    {
        [Fact]
        public void ContagemDeCaracteres_StringComCaracteresUnicos()
        {
            // Arrange
            Ex06 ex06 = new Ex06();
            string input = "abc";

            // Act
            string resultado = ex06.ContagemDeCaracteres(input);

            // Assert
            string expected = "a aparece 1 vez(es).\nb aparece 1 vez(es).\nc aparece 1 vez(es).\n";
            Assert.Equal(expected, resultado);
        }

        [Fact]
        public void ContagemDeCaracteres_StringComCaracteresRepetidos()
        {
            // Arrange
            Ex06 ex06 = new Ex06();
            string input = "aabbcc";

            // Act
            string resultado = ex06.ContagemDeCaracteres(input);

            // Assert
            string expected = "a aparece 2 vez(es).\nb aparece 2 vez(es).\nc aparece 2 vez(es).\n";
            Assert.Equal(expected, resultado);
        }

        [Fact]
        public void ContagemDeCaracteres_StringVazia()
        {
            // Arrange
            Ex06 ex06 = new Ex06();
            string input = "";

            // Act
            string resultado = ex06.ContagemDeCaracteres(input);

            // Assert
            string expected = "";
            Assert.Equal(expected, resultado);
        }

        [Fact]
        public void ContagemDeCaracteres_StringComCaracteresMisturados()
        {
            // Arrange
            Ex06 ex06 = new Ex06();
            string input = "aAaA";

            // Act
            string resultado = ex06.ContagemDeCaracteres(input);

            // Assert
            string expected = "a aparece 2 vez(es).\nA aparece 2 vez(es).\n";
            Assert.Equal(expected, resultado);
        }
    }
}
