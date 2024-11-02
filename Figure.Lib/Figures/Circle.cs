namespace Figure.Lib.Figures;

public class Circle : IFigure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(radius);
        Radius = radius;
    }

    public double GetArea() => Math.PI * Radius * Radius;
}
