namespace RSMS.Controllers.Properties.PropertyTypes;
public static class CreatePropertyTypeTypeController
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