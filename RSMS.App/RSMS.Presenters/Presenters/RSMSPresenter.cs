namespace RSMS.Presenters.Presenters;
internal class RSMSPresenter : IOutputPort
{
    public IOperationResponse OperationResponse { get; private set; }

    public Task Handle(IOperationResponse oOperationResponse)
    {
        OperationResponse = oOperationResponse;
        return Task.CompletedTask;
    }
}