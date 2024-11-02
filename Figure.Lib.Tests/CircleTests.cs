using Figure.Lib.Figures;

namespace Figure.Lib.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(4)]
    public void Create_WithValidRadius_ShouldReturnCircleInstance(double radius)
    {
        var circle = new Circle(radius);

        Assert.Equal(radius, circle.Radius);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void Create_WithNonPositiveRadius_ShouldThrowArgumentOutOfRangeException(double radius)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(4)]
    public void GetArea_WithValidRadius_ShouldReturnCorrectArea(double radius)
    {
        var circle = new Circle(radius);
        var expectedArea = Math.PI * radius * radius;

        Assert.Equal(expectedArea, circle.GetArea());
    }
}