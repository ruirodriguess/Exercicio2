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
    }
}