using Figure.Lib.Figures;

namespace Figure.Lib.Tests;

public class TriangleTests
{
    [Fact]
    public void Create_WithValidSides_ShouldReturnTriangleInstance()
    {
        var sideA = 3;
        var sideB = 4;
        var sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.Equal(sideA, triangle.SideA);
        Assert.Equal(sideB, triangle.SideB);
        Assert.Equal(sideC, triangle.SideC);
    }

    [Theory]
    [InlineData(0, 4, 5)]
    [InlineData(3, -4, 5)]
    [InlineData(3, 4, 0)]
    public void Create_WithNonPositiveSides_ShouldThrowArgumentOutOfRangeException(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 1, 1)]
    [InlineData(5, 1, 3)]
    public void Create_WithInvalidSides_ShouldThrowArgumentException(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(0.1, 0.1, 0.1)]
    [InlineData(0.3, 0.4, 0.5)]
    [InlineData(3, 4, 5)]
    public void GetArea_WithValidSides_ShouldReturnCorrectArea(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        var semiPerimeter = (sideA + sideB + sideC) / 2;
        var expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

        Assert.Equal(expectedArea, triangle.GetArea());
    }

    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(0.3, 0.4, 0.5)]
    public void IsRightTriangle_WithRightTriangleSides_ShouldReturnTrue(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.True(triangle.IsRightTriangle());
    }

    [Theory]
    [InlineData(3, 4, 6)]
    [InlineData(0.3, 0.4, 0.6)]
    public void IsRightTriangle_WithNonRightTriangleSides_ShouldReturnFalse(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.False(triangle.IsRightTriangle());
    }
}
