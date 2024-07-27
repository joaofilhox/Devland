using Xunit;
using Exercicios;

namespace Exercicios.Tests
{
    public class Ex01Tests
    {
        
        [Fact]
        public void SomarDeDoisNumeros_SomaCorretamente()
        {
            // Arrange
            Ex01 ex01 = new Ex01();
            int a = 5;
            int b = 5;

            // Act
            int resultado = ex01.SomarDeDoisNumeros(a, b);

            // Assert
            Assert.Equal(10, resultado);
        }
    }
}
