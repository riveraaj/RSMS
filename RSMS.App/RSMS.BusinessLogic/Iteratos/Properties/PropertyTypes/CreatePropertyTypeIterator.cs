namespace RSMS.BusinessLogic.Iteratos.Properties.PropertyTypes;
internal class CreatePropertyTypeIterator(IPropertyTypeRepository repository,
                                          IOutputPort outputPort) : BaseIterator,
                                                                    ICreateInputPort<CreatePropertyTypeDTO>
{
    private readonly IPropertyTypeRepository _repository = repository;
    private readonly IOutputPort _outputPort = outputPort;

    public async Task Handle(CreatePropertyTypeDTO oCreatePropertyTypeDTO)
    {
        IOperationResponse response;
        try
        {
            // Get result from repository
            bool result = await _repository.CreateAsync(oCreatePropertyTypeDTO);

            // Validate if property type was created
            response = (result) ? new OperationResponseVO() : CustomWarning();
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}