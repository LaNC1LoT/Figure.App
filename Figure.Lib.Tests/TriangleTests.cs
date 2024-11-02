using Figure.Lib.Figures;
using Figure.Lib.Helpers;

namespace Figure.Lib.Tests;

public class TriangleTests
{
    [Fact]
    public void Create_WithValidSides_ShouldReturnTriangleInstance()
    {
        var sideA = 3m;
        var sideB = 4m;
        var sideC = 5m;
        var triangle = Triangle.Create(sideA, sideB, sideC);

        Assert.NotNull(triangle);
        Assert.Equal(sideA, triangle.SideA);
        Assert.Equal(sideB, triangle.SideB);
        Assert.Equal(sideC, triangle.SideC);
    }

    [Theory]
    [InlineData(0, 4, 5)]
    [InlineData(3, -4, 5)]
    [InlineData(3, 4, 0)]
    public void Create_WithNonPositiveSides_ShouldThrowArgumentOutOfRangeException(decimal sideA, decimal sideB, decimal sideC)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Triangle.Create(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 1, 1)]
    [InlineData(5, 1, 3)]
    public void Create_WithInvalidSides_ShouldThrowArgumentException(decimal sideA, decimal sideB, decimal sideC)
    {
        Assert.Throws<ArgumentException>(() => Triangle.Create(sideA, sideB, sideC));
    }

    [Fact]
    public void GetArea_WithValidSides_ShouldReturnCorrectArea()
    {
        var sideA = 3m;
        var sideB = 4m;
        var sideC = 5m;
        var triangle = Triangle.Create(sideA, sideB, sideC);

        var semiPerimeter = (sideA + sideB + sideC) / 2;
        var expectedArea = Math.Round(FigureHelper.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC)), 2);

        Assert.Equal(expectedArea, triangle.GetArea());
    }

    [Fact]
    public void IsRightTriangle_WithRightTriangleSides_ShouldReturnTrue()
    {
        var triangle = Triangle.Create(3m, 4m, 5m);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void IsRightTriangle_WithNonRightTriangleSides_ShouldReturnFalse()
    {
        var triangle = Triangle.Create(3m, 4m, 6m);
        Assert.False(triangle.IsRightTriangle());
    }
}
