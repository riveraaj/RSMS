namespace RSMS.BusinessLogic.Iteratos.Properties;
internal class CreatePropertyIterator(IPropertyRepository repository,
                                      IOutputPort outputPort) : BaseIterator,
                                                                ICreateInputPort<CreatePropertyDTO>
{
    private readonly IPropertyRepository _repository = repository;
    private readonly IOutputPort _outputPort = outputPort;

    public async Task Handle(CreatePropertyDTO oCreatePropertyDTO)
    {
        IOperationResponse response;
        try
        {
            // Get result from repository
            bool result = await _repository.CreateAsync(oCreatePropertyDTO);

            // Validate if property was created
            response = (result) ? new OperationResponseVO() : CustomWarning();
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}