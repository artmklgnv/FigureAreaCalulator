using FigureAreaCalulator;
using FigureAreaCalulator.Figures;

#region create triangle 
Console.WriteLine("Create triangle with sides: 2, 3, 4");
Triangle triangle = new Triangle(2, 3, 4);
double triangleArea = AreaCalculator.Calculate(triangle);
Console.WriteLine($"Triangle area: {triangleArea}");
Console.WriteLine($"Is right trianlge: {triangle.IsRightTriangle().ToString()}");
#endregion

#region create wrong triangle 
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Create triangle with sides: 1, 2, 3");
Triangle wrongTriangle = new Triangle(1, 2, 3);
try
{
    double wrongTriangleArea = AreaCalculator.Calculate(wrongTriangle);
    Console.WriteLine($"Triangle area: {wrongTriangleArea}");
    Console.WriteLine($"Is right trianlge: {wrongTriangle.IsRightTriangle().ToString()}");
}
catch(Exception ex)
{
    Console.WriteLine($"{ex.Message}");
}
#endregion

#region create right triangle 
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Create triangle with sides: 6, 8, 10");
Triangle rightTriangle = new Triangle(6, 8, 10);
double rightTriangleArea = AreaCalculator.Calculate(rightTriangle);
Console.WriteLine($"Triangle area: {rightTriangleArea}");
Console.WriteLine($"Is right trianlge: {rightTriangle.IsRightTriangle().ToString()}");
#endregion

#region create circle
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Create circle with radius: 2");
Circle circle = new Circle(2);
double circleArea = AreaCalculator.Calculate(circle);
Console.WriteLine($"Circle area: {circleArea}");
#endregion

#region create wrong circle 
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Create circle with radius: 0");
Circle wrongCircle = new Circle(0);
try
{
    double wrongCircleArea = AreaCalculator.Calculate(wrongCircle);
    Console.WriteLine($"Circle area: {wrongCircleArea}");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
}
#endregion

Console.ReadLine();
