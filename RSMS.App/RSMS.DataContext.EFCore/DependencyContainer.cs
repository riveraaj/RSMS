namespace RSMS.DataContext.EFCore;
public static class DependencyContainer
{
    public static IServiceCollection AddDataContextServices(this IServiceCollection services,
                                                                 IConfiguration configuration)
    {
        //Contexts
        services.AddDbContext<RealStateDBContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
}