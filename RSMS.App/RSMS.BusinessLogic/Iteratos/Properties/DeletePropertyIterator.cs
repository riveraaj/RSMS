namespace RSMS.BusinessLogic.Iteratos.Properties;
internal class DeletePropertyIterator(IPropertyRepository repository,
                                      IOutputPort outputPort) : BaseIterator,
                                                                IDeleteInputPort
{
    private readonly IPropertyRepository _repository = repository;
    private readonly IOutputPort _outputPort = outputPort;

    public async Task Hanlde(int id)
    {
        IOperationResponse response;
        try
        {
            // Get result from repository
            bool result = await _repository.DeleteAsync(id);

            // Validate if property was deleted
            response = (result) ? new OperationResponseVO() : CustomWarning();
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}