using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Application.Abstractions;
using TaskManagement.Infrastructure.Persistence;
using TaskManagement.Infrastructure.Repositories;

namespace TaskManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // EF Core (in-memory for now)
        services.AddDbContext<AppDbContext>(opt =>
            opt.UseInMemoryDatabase("TaskDb"));

        // Repositories
        services.AddScoped<ITaskRepository, TaskRepository>();

        return services;
    }
}