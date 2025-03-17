namespace RSMS.Controllers.Owners;
public static class GetAllOwnerForPropertyController
{
    public static async Task<IOperationResponse> Handle(
       [FromKeyedServices("GetAllOwnerForProperty")] IGetAllInputPort inputPort,
       IOutputPort presenter)
    {
        await inputPort.Handle();
        return presenter.OperationResponse;
    }
}