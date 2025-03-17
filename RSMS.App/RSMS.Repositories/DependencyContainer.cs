namespace RSMS.Repositories;
public static class DependencyContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        // Owner
        services.AddScoped<IOwnerRepository, OwnerCommandsRepository>();

        // Property
        services.AddScoped<IPropertyRepository, PropertyCommandsRepository>();

        // Property Type
        services.AddScoped<IPropertyTypeRepository, PropertyTypeCommandsRepository>();

        return services;
    }
}