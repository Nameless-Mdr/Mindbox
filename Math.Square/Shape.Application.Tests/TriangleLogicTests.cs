using Microsoft.Extensions.DependencyInjection;
using Shape.Application.Extensions;
using Shape.Application.Services;
using Shape.Domain.Models;

namespace Shape.Application.Tests;

public class TriangleLogicTests : IDisposable
{
    private readonly ServiceProvider _serviceProvider;
    private readonly ShapeService _shapeService;
    
    public TriangleLogicTests()
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
    public void CalculateArea_Triangle()
    {
        var triangle = new Triangle { A = 3, B = 4, C = 5 };

        var area = _shapeService.CalculateArea<Triangle, double>(triangle);

        Assert.Equal(6, area, 3);
    }

    [Fact]
    public void IsRightAngled_RightAngledTriangle()
    {
        var triangle = new Triangle { A = 3, B = 4, C = 5 };

        var isRightAngled = _shapeService.IsRightAngled(triangle);

        Assert.True(isRightAngled);
    }

    [Fact]
    public void IsRightAngled_NonRightAngledTriangle()
    {
        var triangle = new Triangle { A = 3, B = 5, C = 7 };

        var isRightAngled = _shapeService.IsRightAngled(triangle);

        Assert.False(isRightAngled);
    }
}