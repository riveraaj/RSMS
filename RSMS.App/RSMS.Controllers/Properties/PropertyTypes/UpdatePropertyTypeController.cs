namespace RSMS.Controllers.Properties.PropertyTypes;
public static class UpdatePropertyTypeTypeController
{
    public static async Task<IOperationResponse> Handle(
        UpdatePropertyTypeDTO oUpdatePropertyTypeDTO,
        IUpdateInputPort<UpdatePropertyTypeDTO> inputPort,
        IOutputPort presenter)
    {
        await inputPort.Handle(oUpdatePropertyTypeDTO);
        return presenter.OperationResponse;
    }
}