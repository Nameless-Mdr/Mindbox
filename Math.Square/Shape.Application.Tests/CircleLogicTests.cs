using Microsoft.Extensions.DependencyInjection;
using Shape.Application.Extensions;
using Shape.Application.Services;
using Shape.Domain.Models;

namespace Shape.Application.Tests;

public class CircleLogicTests : IDisposable
{
    private readonly ServiceProvider _serviceProvider;
    private readonly ShapeService _shapeService;
    
    public CircleLogicTests()
    {
        var services = new ServiceCollection();
        services.AddShapes();
        services.AddTransient<ShapeService>();

        _serviceProvider = services.BuildServiceProvider();
        _shapeService = _serviceProvider.GetRequiredService<ShapeService>();
    }

    public void Dispose()
    {
        _serviceProvider.Dispose();
    }
    
    [Fact]
    public void CalculateArea_Circle()
    {
        var circle = new Circle { Radius = 5 };

        var area = _shapeService.CalculateArea<Circle, double>(circle);

        Assert.Equal(Math.PI * 25, area, 3);
    }
}