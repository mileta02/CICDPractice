using CICDPractice.Services;

namespace Tests;

public class CalculatorServiceTests
{
    private readonly CalculatorService _sut = new();

    [Theory]
    [InlineData(3, 4, 7)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, -3, -8)]
    public void Add_VariousInputs_ReturnsCorrectSum(double a, double b, double expected)
    {
        var result = _sut.Add(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 3, 7)]
    [InlineData(0, 5, -5)]
    [InlineData(-4, -2, -2)]
    public void Subtract_VariousInputs_ReturnsCorrectDifference(double a, double b, double expected)
    {
        var result = _sut.Subtract(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(-2, 5, -10)]
    [InlineData(0, 99, 0)]
    public void Multiply_VariousInputs_ReturnsCorrectProduct(double a, double b, double expected)
    {
        var result = _sut.Multiply(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(9, 3, 3)]
    [InlineData(-6, 2, -3)]
    public void Divide_VariousInputs_ReturnsCorrectQuotient(double a, double b, double expected)
    {
        var result = _sut.Divide(a, b);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _sut.Divide(5, 0));
    }
}
