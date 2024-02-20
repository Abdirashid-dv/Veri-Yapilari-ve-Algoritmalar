using Maths;

namespace MathTest;

public class UnitTest1
{
    [Fact]
    public void Check_Multiply_Function()
    {
        // Arrange
        var number = new Number(70);

        // Act
        var result = number.Multiply();

        // Assertion
        Assert.Equal(140, result);
    }

    [Fact]
    public void Check_Multiply_Function2()
    {
        // Arrange
        var number = new Number(30);

        // Act
        var result = number.Multiply(5);

        // Assertion
        Assert.True(result != 60);
        Assert.Equal(result.Equals(10), true);
    }
}