﻿namespace RSMS.Controllers.Properties.PropertyTypes;
public static class DeletePropertyTypeController
{
    public static async Task<IOperationResponse> Handle(
       int id,
       [FromKeyedServices("DeletePropertyType")] IDeleteInputPort inputPort,
       IOutputPort presenter)
    {
        await inputPort.Handle(id);
        return presenter.OperationResponse;
    }
}