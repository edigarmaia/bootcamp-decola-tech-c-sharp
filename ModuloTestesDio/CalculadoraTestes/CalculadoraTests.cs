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
}