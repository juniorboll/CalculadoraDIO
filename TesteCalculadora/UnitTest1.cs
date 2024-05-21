namespace UnitTest1;

using CalculadoraDIO;

public class CalculadoraTests
{
    private Calculadora _calc;

    public CalculadoraTests()
    {
        _calc = new Calculadora(DateTime.Now.ToShortDateString());
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    [InlineData(9, 6, 15)]
    public void Somar(int value1, int value2, int resultadoEsperado)
    {
        int resultado = _calc.Somar(value1, value2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(3, 1, 2)]
    [InlineData(10, 5, 5)]
    public void Subtrair(int value1, int value2, int resultadoEsperado)
    {
        int resultado = _calc.Subtrair(value1, value2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(5, 4, 20)]
    [InlineData(10, 6, 60)]
    public void Multiplicar(int value1, int value2, int resultadoEsperado)
    {
        int resultado = _calc.Multiplicar(value1, value2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(8, 4, 2)]
    [InlineData(3, 3, 1)]
    [InlineData(8, 2, 4)]
    public void Dividir(int value1, int value2, int resultadoEsperado)
    {
        int resultado = _calc.Dividir(value1, value2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DividirPorZero()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3, 0)
        );
    }


    [Fact]
    public void Historico()
    {
        _calc.Somar(2, 3);
        _calc.Somar(4, 5);
        _calc.Somar(6, 7);
        _calc.Somar(8, 9);

        var historico = _calc.Historico();

        Assert.NotEmpty(historico);
        Assert.Equal(3, historico.Count);
    }
}