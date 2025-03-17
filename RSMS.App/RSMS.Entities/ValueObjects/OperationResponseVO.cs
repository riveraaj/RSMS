namespace RSMS.Entities.ValueObjects;

public record struct OperationResponseVO(ResponseStatus StatusCode = ResponseStatus.Success,
                                         string Message = null!,
                                         object Content = null!) : IOperationResponse
{
    public OperationResponseVO() : this(ResponseStatus.Success, Commons.SuccessMessage, null!) { }
}