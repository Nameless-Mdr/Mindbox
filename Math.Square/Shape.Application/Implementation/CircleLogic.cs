using Shape.Application.Interfaces;
using Shape.Domain.Models;

namespace Shape.Application.Implementation;

/// <summary>
/// Реализация фигуры (круг)
/// </summary>
public class CircleLogic : ICircle
{
    public double CalculateArea(Circle shape)
    {
        return Math.PI * shape.Radius * shape.Radius;
    }
}