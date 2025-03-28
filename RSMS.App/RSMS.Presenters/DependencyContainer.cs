﻿namespace RSMS.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddPresenterServices(this IServiceCollection services)
    {
        services.AddScoped<IOutputPort, RSMSPresenter>();

        return services;
    }
}