using Figure.Lib.Helpers;

namespace Figure.Lib.Figures;

public sealed class Triangle : IFigure
{
    public decimal SideA { get; }
    public decimal SideB { get; }
    public decimal SideC { get; }

    private Triangle(decimal sideA, decimal sideB, decimal sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public decimal GetArea()
    {
        decimal semiPerimeter = (SideA + SideB + SideC) / 2;
        var result = FigureHelper.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        return Math.Round(result, 2);
    }

    public bool IsRightTriangle()
    {
        decimal[] sides = [SideA, SideB, SideC];
        Array.Sort(sides);
        return FigureHelper.Pow(sides[0], 2) + FigureHelper.Pow(sides[1], 2) == FigureHelper.Pow(sides[2], 2);
    }

    public static Triangle Create(decimal sideA, decimal sideB, decimal sideC)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(sideA, nameof(sideA));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(sideB, nameof(sideB));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(sideC, nameof(sideC));

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("Треугольник с такими сторонами не существует");

        return new Triangle(sideA, sideB, sideC);
    }
}
