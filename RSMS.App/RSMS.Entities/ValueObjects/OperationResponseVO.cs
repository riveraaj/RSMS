namespace RSMS.Entities.ValueObjects;

public record struct OperationResponseVO(ResponseStatus StatusCode = ResponseStatus.Success,
                                         string Message = CommonMessage.SUCCESS,
                                         object Content = null);