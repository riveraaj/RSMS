namespace RSMS.Controllers.Owners;
public static class UpdateOwnerController
{
    public static async Task<IOperationResponse> Handle(
        UpdateOwnerDTO oUpdateOwnerDTO,
        IUpdateInputPort<UpdateOwnerDTO> inputPort,
        IOutputPort presenter)
    {
        await inputPort.Handle(oUpdateOwnerDTO);
        return presenter.OperationResponse;
    }
}