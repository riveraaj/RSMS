namespace RSMS.BusinessLogic.Iteratos.Properties.PropertyTypes;
internal class UpdatePropertyTypeIterator(IPropertyTypeRepository repository,
                                              IOutputPort outputPort) : BaseIterator,
                                                                        IUpdateInputPort<UpdatePropertyTypeDTO>
{
    private readonly IPropertyTypeRepository _repository = repository;
    private readonly IOutputPort _outputPort = outputPort;

    public async Task Handle(UpdatePropertyTypeDTO oUpdatePropertyTypeDTO)
    {
        IOperationResponse response;
        try
        {
            // Get result from repository
            bool result = await _repository.UpdateAsync(oUpdatePropertyTypeDTO);

            // Validate if property type was updated
            response = (result) ? new OperationResponseVO() : CustomWarning();
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}