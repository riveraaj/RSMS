namespace RSMS.DataContext.EFCore;
public static class DependencyContainer
{
    public static IServiceCollection AddDataContextServices(this IServiceCollection services,
                                                                 IConfiguration configuration)
    {
        //Contexts
        services.AddDbContext<RealStateDBContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        //Services
        services.AddScoped<IOwnerCommandsDataContext, OwnerCommandsDataContext>();
        services.AddScoped<IPropertyCommandsDataContext, PropertyCommandsDataContext>();
        services.AddScoped<IPropertyTypeCommandsDataContext, PropertyTypeCommandsDataContext>();

        return services;
    }
}