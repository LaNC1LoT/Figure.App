using Figure.Lib.Figures;
using Figure.Lib.Helpers;

namespace Figure.Lib.Tests;

public class CircleTests
{
    [Fact]
    public void Create_WithValidRadius_ShouldReturnCircleInstance()
    {
        var radius = 5m;
        var circle = Circle.Create(radius);

        Assert.Equal(radius, circle.Radius);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void Create_WithNonPositiveRadius_ShouldThrowArgumentOutOfRangeException(decimal radius)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Circle.Create(radius));
    }

    [Fact]
    public void GetArea_WithValidRadius_ShouldReturnCorrectArea()
    {
        var radius = 5m;
        var circle = Circle.Create(radius);
        var expectedArea = FigureHelper.PI * radius * radius;

        Assert.Equal(expectedArea, circle.GetArea());
    }
}