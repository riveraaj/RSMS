namespace RSMS.BusinessLogic.Iteratos.Properties;
internal class UpdatePropertyIterator(IPropertyRepository repository,
                                      IOutputPort outputPort) : BaseIterator,
                                                                IUpdateInputPort<UpdatePropertyDTO>
{
    private readonly IPropertyRepository _repository = repository;
    private readonly IOutputPort _outputPort = outputPort;

    public async Task Handle(UpdatePropertyDTO oUpdatePropertyDTO)
    {
        IOperationResponse response;
        try
        {
            // Get result from repository
            bool result = await _repository.UpdateAsync(oUpdatePropertyDTO);

            // Validate if property was updated
            response = (result) ? new OperationResponseVO() : CustomWarning();
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}