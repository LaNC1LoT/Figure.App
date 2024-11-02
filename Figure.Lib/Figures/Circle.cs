using Figure.Lib.Helpers;

namespace Figure.Lib.Figures;

public sealed class Circle : IFigure
{
    public decimal Radius { get; }

    private Circle(decimal radius)
    {
        Radius = radius;
    }

    public static Circle Create(decimal radius)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(radius, nameof(radius));
        return new Circle(radius);
    }

    public decimal GetArea() => FigureHelper.PI * Radius * Radius;

}
