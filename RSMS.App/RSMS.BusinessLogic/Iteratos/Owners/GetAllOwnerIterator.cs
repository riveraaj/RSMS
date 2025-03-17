namespace RSMS.BusinessLogic.Iteratos.Owners;
internal class GetAllOwnerIterator(IOwnerRepository repository,
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
                Content = await _repository.GetAllAsync()
            };
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}