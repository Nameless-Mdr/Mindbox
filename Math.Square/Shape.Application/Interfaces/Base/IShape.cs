using Shape.Domain.Interfaces;

namespace Shape.Application.Interfaces.Base;

/// <summary>
/// Интерфейс для фигуры
/// </summary>
public interface IShape<TShape, T>
    where TShape : IShape<T>
    where T : struct
{
    /// <summary>
    /// Расчет площади
    /// </summary>
    /// <returns>Площадь фигуры</returns>
    double CalculateArea(TShape shape);
}