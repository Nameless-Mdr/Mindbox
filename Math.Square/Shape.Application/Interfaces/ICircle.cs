using Shape.Application.Interfaces.Base;
using Shape.Domain.Models;

namespace Shape.Application.Interfaces;

/// <summary>
/// Интерфейс фигуры (круг)
/// </summary>
public interface ICircle : IShape<Circle, double>
{
    
}