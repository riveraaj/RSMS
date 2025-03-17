namespace RSMS.Controllers.Properties;
public static class UpdatePropertyController
{
    public static async Task<IOperationResponse> Handle(
        UpdatePropertyDTO oUpdatePropertyDTO,
        IUpdateInputPort<UpdatePropertyDTO> inputPort,
        IOutputPort presenter)
    {
        await inputPort.Handle(oUpdatePropertyDTO);
        return presenter.OperationResponse;
    }
}