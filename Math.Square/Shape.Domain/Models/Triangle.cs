using Shape.Domain.Interfaces;

namespace Shape.Domain.Models;

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : IShape<double>
{
    /// <summary>
    /// Сторона A
    /// </summary>
    public double A { get; set; }
    
    /// <summary>
    /// Сторона B
    /// </summary>
    public double B { get; set; }
    
    /// <summary>
    /// Сторона C
    /// </summary>
    public double C { get; set; }
}