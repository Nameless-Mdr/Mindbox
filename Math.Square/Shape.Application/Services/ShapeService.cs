using Microsoft.Extensions.DependencyInjection;
using Shape.Application.Interfaces;
using Shape.Application.Interfaces.Base;
using Shape.Domain.Interfaces;
using Shape.Domain.Models;

namespace Shape.Application.Services;

public class ShapeService
{
    private readonly IServiceProvider _serviceProvider;

    public ShapeService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public double CalculateArea<TShape, T>(TShape shape)
        where TShape : class, IShape<T>
        where T : struct
    {
        var logic = _serviceProvider.GetRequiredService<IShape<TShape, T>>();
        return logic.CalculateArea(shape);
    }

    public bool IsRightAngled(Triangle triangle)
    {
        var triangleLogic = _serviceProvider.GetService<ITriangle>();
        return triangleLogic != null && triangleLogic.IsRightAngled(triangle);
    }
}