namespace CalculadoraTestes;
using Calculadora.Services;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10eRetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act

        int resultado = _calc.Somar(num1, num2);

        // Assert

        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSoma105Com10eRetornar15()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act

        int resultado = _calc.Somar(num1, num2);

        // Assert

        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EParERetornarVerdaeiro()
    {
        // Arrange
        int num1 = 4;


        // Act

        bool resultado = _calc.Par(num1);

        // Assert

        Assert.True(resultado);

    }

    [Theory]
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    // [InlineData(12)]
    // [InlineData(14)]
    [InlineData(new int[] { 2,4})]
    [InlineData(new int[] { 6,4,8,10,12})]
     public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadiero(int[] numeros)
    {
    
        Assert.All(numeros, num => Assert.True(_calc.Par(num)));
       
        // // Act
        // bool resultado = _calc.Par(numero);
    
        // // Assert
        // Assert.True(resultado);
        
    }




}