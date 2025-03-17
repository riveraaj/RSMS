namespace RSMS.BusinessLogic.Iteratos.Owners;
internal class GetAllOwnerForPropertyIterator(IOwnerRepository repository,
                                              IOutputPort outputPort) : BaseIterator,
                                                                        IGetAllInputPort
{
    private readonly IOwnerRepository _repository = repository;
    private readonly IOutputPort _outputPort = outputPort;

    public async Task Handle()
    {
        IOperationResponse response;
        try
        {
            // Get data from repository
            response = new OperationResponseVO
            {
                Content = await _repository.GetAllForPropertyAsync()
            };
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}