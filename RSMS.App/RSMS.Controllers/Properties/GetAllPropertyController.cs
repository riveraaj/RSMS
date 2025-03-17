namespace RSMS.Controllers.Properties;
public static class GetAllPropertyController
{
    public static async Task<IOperationResponse> Handle(
       [FromKeyedServices("GetAllProperty")] IGetAllInputPort inputPort,
       IOutputPort presenter)
    {
        await inputPort.Handle();
        return presenter.OperationResponse;
    }
}