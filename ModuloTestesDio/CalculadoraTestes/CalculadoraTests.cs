using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange - montar cenário
        int num1 = 5;
        int num2 = 10;

        // Act - chamar o cenário
        int resultado = _calc.Somar(num1, num2);

        // Assert - validar se teve resultado esperado
        Assert.Equal(15, resultado);

    }

     [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange - montar cenário
        int num1 = 10;
        int num2 = 10;

        // Act - chamar o cenário
        int resultado = _calc.Somar(num1, num2);

        // Assert - validar se teve resultado esperado
        Assert.Equal(20, resultado);

    }
    [Fact]
    public void DeveSubtrair20Menos10ERetornar10()
    {
        // Arrange
        int num1 = 20;
        int num2 = 10;

        // Act
        int resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(10, resultado);
    }

     [Fact]
    public void DeveMultiplicar10Com15ERetornar150()
    {
        // Arrange
        int num1 = 10;
        int num2 = 15;

        // Act
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(150, resultado);
    }

     [Fact]
    public void DeveDividir100Por10ERetornar10()
    {
        // Arrange
        int num1 = 100;
        int num2 = 10;

        // Act
        int resultado = _calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(10, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Arrange
        int numero = 4;

        // Act
        bool resultado = _calc.EhPar(numero);

        // Assert
        Assert.True(resultado);
    }
}