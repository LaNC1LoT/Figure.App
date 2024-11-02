namespace Figure.Lib.Figures;

public class Triangle : IFigure
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(sideA);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(sideB);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(sideC);

        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(sideC, sideA + sideB);
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(sideB, sideA + sideC);
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(sideA, sideB + sideC);

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double GetArea()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    public bool IsRightTriangle()
    {
        double[] sides = [SideA, SideB, SideC];
        Array.Sort(sides);
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}
