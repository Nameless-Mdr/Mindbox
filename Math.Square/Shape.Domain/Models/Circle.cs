using Shape.Domain.Interfaces;

namespace Shape.Domain.Models;

/// <summary>
/// Круг
/// </summary>
public class Circle : IShape<double>
{
    /// <summary>
    /// Радиус
    /// </summary>
    public double Radius { get; set; }
}