namespace RSMS.Controllers.Properties;
public static class CreatePropertyController
{
    public static async Task<IOperationResponse> Handle(
        CreatePropertyDTO oCreatePropertyDTO,
        ICreateInputPort<CreatePropertyDTO> inputPort,
        IOutputPort presenter)
    {
        await inputPort.Handle(oCreatePropertyDTO);
        return presenter.OperationResponse;
    }
}