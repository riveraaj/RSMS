namespace RSMS.Controllers.Properties.PropertyTypes;
public static class GetAllPropertyTypeTypeController
{
    public static async Task<IOperationResponse> Handle(
       [FromKeyedServices("GetAllPropertyType")] IGetAllInputPort inputPort,
       IOutputPort presenter)
    {
        await inputPort.Handle();
        return presenter.OperationResponse;
    }
}