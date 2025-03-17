namespace RSMS.BusinessLogic;
public static class DependencyContainer
{
    public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services)
    {
        // Owner
        services.AddScoped<IGetAllInputPort, GetAllOwnerIterator>();
        services.AddScoped<IGetAllInputPort, GetAllOwnerForPropertyIterator>();
        services.AddScoped<ICreateInputPort<CreateOwnerDTO>, CreateOwnerIterator>();
        services.AddScoped<IUpdateInputPort<UpdateOwnerDTO>, UpdateOwnerIterator>();
        services.AddScoped<IDeleteInputPort, DeleteOwnerIterator>();

        // Property
        services.AddScoped<IGetAllInputPort, GetAllPropertyIterator>();
        services.AddScoped<ICreateInputPort<CreatePropertyDTO>, CreatePropertyIterator>();
        services.AddScoped<IUpdateInputPort<UpdatePropertyDTO>, UpdatePropertyIterator>();
        services.AddScoped<IDeleteInputPort, DeletePropertyIterator>();

        // Property Type
        services.AddScoped<IGetAllInputPort, GetAllPropertyTypeIterator>();
        services.AddScoped<ICreateInputPort<CreatePropertyTypeDTO>, CreatePropertyTypeIterator>();
        services.AddScoped<IUpdateInputPort<UpdatePropertyTypeDTO>, UpdatePropertyTypeIterator>();
        services.AddScoped<IDeleteInputPort, DeletePropertyTypeIterator>();

        return services;
    }
}