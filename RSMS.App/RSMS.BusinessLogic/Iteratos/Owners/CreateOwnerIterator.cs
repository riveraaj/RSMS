namespace RSMS.BusinessLogic.Iteratos.Owners;
internal class CreateOwnerIterator(IOwnerRepository repository,
                                   IOutputPort outputPort) : BaseIterator,
                                                             ICreateInputPort<CreateOwnerDTO>
{
    private readonly IOwnerRepository _repository = repository;
    private readonly IOutputPort _outputPort = outputPort;

    public async Task Handle(CreateOwnerDTO oCreateOwnerDTO)
    {
        IOperationResponse response;
        try
        {
            // Get result from repository
            bool result = await _repository.CreateAsync(oCreateOwnerDTO);

            // Validate if owner was created
            response = (result) ? new OperationResponseVO() : CustomWarning();
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}