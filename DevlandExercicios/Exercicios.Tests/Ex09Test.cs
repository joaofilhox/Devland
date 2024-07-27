using Xunit;
using Exercicios;

namespace Exercicios.Tests
{
    public class Ex09Test
    {
        [Fact]
        public void OrdenacaoDeNomes_OrdenaCorretamente()
        {
            // Arrange
            Ex09 ex09 = new Ex09();
            string[] nomes = { "Carlos", "Ana", "Bruno", "Daniela" };
            string[] nomesEsperados = { "Ana", "Bruno", "Carlos", "Daniela" };

            // Act
            string[] nomesOrdenados = ex09.OrdenacaoDeNomes(nomes);

            // Assert
            Assert.Equal(nomesEsperados, nomesOrdenados);
        }

        [Fact]
        public void OrdenacaoDeNomes_ListaVazia()
        {
            // Arrange
            Ex09 ex09 = new Ex09();
            string[] nomes = { };
            string[] nomesEsperados = { };

            // Act
            string[] nomesOrdenados = ex09.OrdenacaoDeNomes(nomes);

            // Assert
            Assert.Equal(nomesEsperados, nomesOrdenados);
        }

        [Fact]
        public void OrdenacaoDeNomes_ListaComUmElemento()
        {
            // Arrange
            Ex09 ex09 = new Ex09();
            string[] nomes = { "Ana" };
            string[] nomesEsperados = { "Ana" };

            // Act
            string[] nomesOrdenados = ex09.OrdenacaoDeNomes(nomes);

            // Assert
            Assert.Equal(nomesEsperados, nomesOrdenados);
        }
    }
}
