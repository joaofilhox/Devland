using Xunit;
using Exercicios;

namespace Exercicios.Tests
{
    public class Exercicio04Tests
    {
        [Fact]
        public void InversaoDeString_PalavraSimples()
        {
            // Arrange
            Ex04 ex04 = new Ex04();
            string input = "abcd";

            // Act
            string resultado = ex04.InversaoDeString(input);

            // Assert
            Assert.Equal("dcba", resultado);
        }

        [Fact]
        public void InversaoDeString_ComEspacos()
        {
            // Arrange
            Ex04 ex04 = new Ex04();
            string input = "a b c";

            // Act
            string resultado = ex04.InversaoDeString(input);

            // Assert
            Assert.Equal("c b a", resultado);
        }

        [Fact]
        public void InversaoDeString_StringVazia()
        {
            // Arrange
            Ex04 ex04 = new Ex04();
            string input = "";

            // Act
            string resultado = ex04.InversaoDeString(input);

            // Assert
            Assert.Equal("", resultado);
        }

        [Fact]
        public void InversaoDeString_StringComUmCaractere()
        {
            // Arrange
            Ex04 ex04 = new Ex04();
            string input = "a";

            // Act
            string resultado = ex04.InversaoDeString(input);

            // Assert
            Assert.Equal("a", resultado);
        }

        [Fact]
        public void InversaoDeString_ComCaracteresEspeciais()
        {
            // Arrange
            Ex04 ex04 = new Ex04();
            string input = "!@#";

            // Act
            string resultado = ex04.InversaoDeString(input);

            // Assert
            Assert.Equal("#@!", resultado);
        }
    }
}
