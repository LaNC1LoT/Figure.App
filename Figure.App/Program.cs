using Figure.Lib.Figures;

List<IFigure> figures = [ new Circle(5), new Triangle(0.1, 0.1, 0.1) ];

var triangle = new Triangle(0.3, 0.4, 0.5);
Console.WriteLine($"Треугольник прямоугольные: {triangle.IsRightTriangle()}");

foreach (var figure in figures)
{
    Console.WriteLine($"Площадь фигуры: {figure.GetArea()}");
}
