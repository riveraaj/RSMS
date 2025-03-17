namespace RSMS.Controllers.Properties;
public static class DeletePropertyController
{
    public static async Task<IOperationResponse> Handle(
       int id,
       [FromKeyedServices("DeleteProperty")] IDeleteInputPort inputPort,
       IOutputPort presenter)
    {
        await inputPort.Handle(id);
        return presenter.OperationResponse;
    }
}