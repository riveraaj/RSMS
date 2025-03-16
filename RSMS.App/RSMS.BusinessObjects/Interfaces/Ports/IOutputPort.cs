namespace RSMS.BusinessObjects.Interfaces.Ports;

public interface IOutputPort
{
    IOperationResponse OperationResponse { get; }
    Task Handle(IOperationResponse oOperationResponse);
}