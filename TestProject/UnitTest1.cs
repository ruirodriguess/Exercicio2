using ClassLibrary;

namespace TestProject
{
    public class TesteCumprimento
    {
        [Fact]
        public void DeveTestarBomDia()
        {
            // Arrange
            System.DateTime hora = new System.DateTime(2023, 05, 09, 08, 30, 00);

            // Act
            string cumprimento = Cumprimento.ObterCumprimento(hora);

            // Assert
            Assert.Equal("Bom dia, Rui", cumprimento);
        }

        [Fact]
        public void DeveTestarBoaTarde()
        {
            // Arrange
            System.DateTime hora = new System.DateTime(2023, 05, 09, 15, 30, 00);

            // Act
            string cumprimento = Cumprimento.ObterCumprimento(hora);

            // Assert
            Assert.Equal("Boa tarde, Rui", cumprimento);
        }

        [Fact]
        public void DeveTestarBoaNoite()
        {
            // Arrange
            System.DateTime hora = new System.DateTime(2023, 05, 09, 22, 30, 00);

            // Act
            string cumprimento = Cumprimento.ObterCumprimento(hora);

            // Assert
            Assert.Equal("Boa noite, Rui", cumprimento);
        }
    }
}