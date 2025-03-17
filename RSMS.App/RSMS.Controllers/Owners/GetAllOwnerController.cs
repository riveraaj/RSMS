namespace RSMS.Controllers.Owners;
public static class GetAllOwnerController
{
    public static async Task<IOperationResponse> Handle(
       [FromKeyedServices("GetAllOwner")] IGetAllInputPort inputPort,
       IOutputPort presenter)
    {
        await inputPort.Handle();
        return presenter.OperationResponse;
    }
}