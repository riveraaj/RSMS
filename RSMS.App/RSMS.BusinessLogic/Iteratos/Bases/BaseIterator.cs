namespace RSMS.BusinessLogic.Iteratos.Bases;
internal abstract class BaseIterator
{
    protected static IOperationResponse CustomWarning(string message) => new OperationResponseVO
    {
        Message = message,
        StatusCode = ResponseStatus.Warning
    };

    protected static IOperationResponse CustomWarning() => new OperationResponseVO
    {
        Message = Commons.WarningMessage,
        StatusCode = ResponseStatus.Warning
    };

    protected static IOperationResponse CustomError(string message) => new OperationResponseVO
    {
        Message = message,
        StatusCode = ResponseStatus.Error
    };

    protected static IOperationResponse CustomError() => new OperationResponseVO
    {
        Message = Commons.ErrorMessage,
        StatusCode = ResponseStatus.Error
    };
}