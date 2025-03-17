namespace RSMS.Controllers.Owners;
class DeleteOwnerController
{
    public static async Task<IOperationResponse> Handle(
       int id,
       [FromKeyedServices("DeleteOwner")] IDeleteInputPort inputPort,
       IOutputPort presenter)
    {
        await inputPort.Handle(id);
        return presenter.OperationResponse;
    }
}