using Figure.Lib.Figures;

List<IFigure> shapes = [ Circle.Create(5), Triangle.Create(3, 4, 5) ];

foreach (var shape in shapes)
{
    Console.WriteLine($"Площадь фигуры: {shape.GetArea()}");
}