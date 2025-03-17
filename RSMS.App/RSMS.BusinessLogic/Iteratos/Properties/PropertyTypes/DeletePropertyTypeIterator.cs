namespace RSMS.BusinessLogic.Iteratos.Properties.PropertyTypes;
internal class DeletePropertyTypeIterator(IPropertyTypeRepository repository,
                                              IOutputPort outputPort) : BaseIterator,
                                                                        IDeleteInputPort
{
    private readonly IPropertyTypeRepository _repository = repository;
    private readonly IOutputPort _outputPort = outputPort;

    public async Task Handle(int id)
    {
        IOperationResponse response;
        try
        {
            // Get result from repository
            bool result = await _repository.DeleteAsync(id);

            // Validate if property type was deleted
            response = (result) ? new OperationResponseVO() : CustomWarning();
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}