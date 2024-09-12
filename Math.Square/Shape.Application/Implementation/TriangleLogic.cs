using Shape.Application.Interfaces;
using Shape.Domain.Models;

namespace Shape.Application.Implementation;

/// <summary>
/// Реализация фигуры (треугольник)
/// </summary>
public class TriangleLogic : ITriangle
{
    public double CalculateArea(Triangle shape)
    {
        var s = (shape.A + shape.B + shape.C) / 2;
        return Math.Sqrt(s * (s - shape.A) * (s - shape.B) * (s - shape.C));
    }

    public bool IsRightAngled(Triangle triangle)
    {
        return triangle.A * triangle.A + triangle.B * triangle.B == triangle.C * triangle.C ||
               triangle.A * triangle.A + triangle.C * triangle.C == triangle.B * triangle.B ||
               triangle.B * triangle.B + triangle.C * triangle.C == triangle.A * triangle.A;
    }
}