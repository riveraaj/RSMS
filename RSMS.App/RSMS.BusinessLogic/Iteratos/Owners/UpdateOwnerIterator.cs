namespace RSMS.BusinessLogic.Iteratos.Owners;
internal class UpdateOwnerIterator(IOwnerRepository repository,
                                   IOutputPort outputPort) : BaseIterator,
                                                             IUpdateInputPort<UpdateOwnerDTO>
{
    private readonly IOwnerRepository _repository = repository;
    private readonly IOutputPort _outputPort = outputPort;

    public async Task Handle(UpdateOwnerDTO oUpdateOwnerDTO)
    {
        IOperationResponse response;
        try
        {
            // Get result from repository
            bool result = await _repository.UpdateAsync(oUpdateOwnerDTO);

            // Validate if owner was updated
            response = (result) ? new OperationResponseVO() : CustomWarning();
        }
        catch
        {
            response = CustomError();
        }

        await _outputPort.Handle(response);
    }
}