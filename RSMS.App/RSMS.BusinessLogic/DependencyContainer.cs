namespace RSMS.BusinessLogic;
public static class DependencyContainer
{
    public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services)
    {
        // Owner
        services.AddKeyedScoped<IGetAllInputPort, GetAllOwnerIterator>("GetAllOwner");
        services.AddKeyedScoped<IGetAllInputPort, GetAllOwnerForPropertyIterator>("GetAllOwnerForProperty");
        services.AddScoped<ICreateInputPort<CreateOwnerDTO>, CreateOwnerIterator>();
        services.AddScoped<IUpdateInputPort<UpdateOwnerDTO>, UpdateOwnerIterator>();
        services.AddKeyedScoped<IDeleteInputPort, DeleteOwnerIterator>("DeleteOwner");

        // Property
        services.AddKeyedScoped<IGetAllInputPort, GetAllPropertyIterator>("GetAllProperty");
        services.AddScoped<ICreateInputPort<CreatePropertyDTO>, CreatePropertyIterator>();
        services.AddScoped<IUpdateInputPort<UpdatePropertyDTO>, UpdatePropertyIterator>();
        services.AddKeyedScoped<IDeleteInputPort, DeletePropertyIterator>("DeleteProperty");

        // Property Type
        services.AddKeyedScoped<IGetAllInputPort, GetAllPropertyTypeIterator>("GetAllPropertyType");
        services.AddScoped<ICreateInputPort<CreatePropertyTypeDTO>, CreatePropertyTypeIterator>();
        services.AddScoped<IUpdateInputPort<UpdatePropertyTypeDTO>, UpdatePropertyTypeIterator>();
        services.AddKeyedScoped<IDeleteInputPort, DeletePropertyTypeIterator>("DeletePropertyType");

        return services;
    }
}