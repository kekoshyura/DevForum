using DevForum.Application.Questions;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace DevForum.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddProgramDependencies(this IServiceCollection services)
    {
        return services.AddWebDependencies()
            .AddApplication(); 
    }
    
    private static IServiceCollection AddWebDependencies(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        return services;
    }
}