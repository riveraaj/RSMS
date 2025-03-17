namespace RSMS.Controllers.Properties.PropertyTypes;
public static class CreatePropertyTypeController
{
    public static async Task<IOperationResponse> Handle(
        CreatePropertyTypeDTO oCreatePropertyTypeDTO,
        ICreateInputPort<CreatePropertyTypeDTO> inputPort,
        IOutputPort presenter)
    {
        await inputPort.Handle(oCreatePropertyTypeDTO);
        return presenter.OperationResponse;
    }
}