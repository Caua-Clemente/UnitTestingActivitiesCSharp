namespace Atividade13.Tests;

public class FactorialCalculatorTests
{
    [Fact]
    public void Calculate_ReturnOne_WhenCalculatingZeroOrOne()
    {
        var calculadora = new FactorialCalculator();

        Assert.Equal(1, calculadora.Calculate(0));
        Assert.Equal(1, calculadora.Calculate(1));
    }
    
    [Fact]
    public void Calculate_ReturnFactorial_WhenNumberIsGreaterThanOne()
    {
        var calculadora = new FactorialCalculator();

        Assert.Equal(120, calculadora.Calculate(5));
        Assert.Equal(3628800, calculadora.Calculate(10));
    }

    [Fact]
    public void Calculate_ThrowsArgumentException_WhenNumberIsNegative()
    {
        var calculadora = new FactorialCalculator();

        Assert.Throws<ArgumentException>(() => calculadora.Calculate(-1));
        Assert.Throws<ArgumentException>(() => calculadora.Calculate(-10));
    }

    //Aqui também não sei se deveria colocar o null exception, voltando 
    //à minha dúvida da questão anterior
}
