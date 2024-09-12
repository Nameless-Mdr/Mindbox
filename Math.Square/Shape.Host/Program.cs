using Microsoft.Extensions.DependencyInjection;
using Shape.Application.Extensions;
using Shape.Application.Services;
using Shape.Domain.Models;

#region Startup

var services = new ServiceCollection();

services.AddShapes();

services.AddTransient<ShapeService>();

var serviceProvider = services.BuildServiceProvider();

#endregion

var shapeService = serviceProvider.GetRequiredService<ShapeService>();

// Работа с кругом
var circle = new Circle { Radius = 5 };
var circleArea = shapeService.CalculateArea<Circle, double>(circle);
Console.WriteLine($"Площадь круга: {circleArea}");

// Работа с треугольником
var triangle = new Triangle { A = 3, B = 4, C = 5 };
var triangleArea = shapeService.CalculateArea<Triangle, double>(triangle);
Console.WriteLine($"Площадь треугольника: {triangleArea}");

// Проверка на прямоугольность
var isRightAngled = shapeService.IsRightAngled(triangle);
Console.WriteLine($"Треугольник прямоугольный? {isRightAngled}");

triangle = new Triangle { A = 4, B = 9, C = 6 };
isRightAngled = shapeService.IsRightAngled(triangle);
Console.WriteLine($"Треугольник прямоугольный? {isRightAngled}");

Console.ReadKey();