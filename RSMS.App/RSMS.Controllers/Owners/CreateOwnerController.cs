namespace RSMS.Controllers.Owners;
public static class CreateOwnerController
{
    public static async Task<IOperationResponse> Handle(
        CreateOwnerDTO oCreateOwnerDTO,
        ICreateInputPort<CreateOwnerDTO> inputPort,
        IOutputPort presenter)
    {
        await inputPort.Handle(oCreateOwnerDTO);
        return presenter.OperationResponse;
    }
}