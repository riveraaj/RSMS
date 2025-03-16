namespace RSMS.Entities.Interfaces;
public interface IOperationResponse
{
    ResponseStatus StatusCode { get; }
    string Message { get; }
    object Content { get; }
}