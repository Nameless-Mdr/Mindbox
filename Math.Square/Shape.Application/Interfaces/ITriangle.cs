using Shape.Application.Interfaces.Base;
using Shape.Domain.Models;

namespace Shape.Application.Interfaces;

/// <summary>
/// Интерфейс фигуры (треугольник)
/// </summary>
public interface ITriangle : IShape<Triangle, double>
{
    /// <summary>
    /// Проверка, является ли треугольник прямоугольным
    /// </summary>
    /// <returns>True/False</returns>
    bool IsRightAngled(Triangle triangle);
}