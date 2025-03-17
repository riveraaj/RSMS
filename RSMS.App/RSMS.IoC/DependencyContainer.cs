namespace RSMS.IoC;
public static class DependencyContainer
{
    public static IServiceCollection AddRSMSServices(this IServiceCollection services,
                                                          IConfiguration configuration)
    {
        services.AddBusinessLogicServices()
                .AddRepositories()
                .AddDataContextServices(configuration)
                .AddPresenterServices();

        return services;
    }
}