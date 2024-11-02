namespace Figure.Lib.Helpers;

public static class FigureHelper
{
    public const decimal PI = 3.14m;
    public static decimal Pow(decimal value, int exponent)
    {
        decimal result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= value;
        }
        return result;
    }

    public static decimal Sqrt(decimal value, decimal epsilon = 0.01m)
    {
        if (value < 0) throw new ArgumentException("Cannot calculate square root of a negative number");

        decimal current = value / 2;
        decimal previous;
        do
        {
            previous = current;
            current = (previous + value / previous) / 2;
        }
        while (Math.Abs(previous - current) > epsilon);

        return current;
    }
}
