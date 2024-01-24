using System;
using Xunit;

public class PrimosTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(17, true)]
    [InlineData(25, false)]
    public void Es_Primo_DeberiaDevolverResultadoCorrecto(int numero, bool resultadoEsperado)
    {
        // Arrange
        // Puedes inicializar objetos, variables u otros estados necesarios

        // Act
        bool resultadoReal = Program.Es_Primo(numero);

        // Assert
        Assert.Equal(resultadoEsperado, resultadoReal);
    }
}
