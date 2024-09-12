using Microsoft.Extensions.DependencyInjection;
using Shape.Application.Implementation;
using Shape.Application.Interfaces;
using Shape.Application.Interfaces.Base;
using Shape.Domain.Models;

namespace Shape.Application.Extensions;

/// <summary>
/// Регистрация сервисов
/// </summary>
public static class LogicRegistrar
{
    /// <summary>
    /// Регистрация реализаций фигур
    /// </summary>
    /// <param name="services">Коллекция сервисов</param>
    /// <returns>Коллекция сервисов</returns>
    public static IServiceCollection AddShapes(this IServiceCollection services)
    {
        services.AddTransient<IShape<Triangle, double>, TriangleLogic>();
        services.AddTransient<ITriangle, TriangleLogic>();

        services.AddTransient<IShape<Circle, double>, CircleLogic>();
        services.AddTransient<ICircle, CircleLogic>();
        
        return services;
    }
}