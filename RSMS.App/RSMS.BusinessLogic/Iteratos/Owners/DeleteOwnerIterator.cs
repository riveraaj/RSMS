namespace RSMS.BusinessLogic.Iteratos.Owners;
internal class DeleteOwnerIterator(IOwnerRepository repository,
                                   IOutputPort outputPort) : BaseIterator,
                                                             IDeleteInputPort
{
    private readonly IOwnerRepository _repository = repository;
    private readonly IOutputPort _outputPort = outputPort;

    public async Task Handle(int id)
    {
        IOperationResponse response;
        try
        {
            // Get result from repository
            bool result = await _repository.DeleteAsync(id);

            // Validate if owner was deleted
            response = (result) ? new OperationResponseVO() : CustomWarning();
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}