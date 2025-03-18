namespace RSMS.WebClient.Controllers.Properties;
public class PropertyController([FromKeyedServices("GetAllProperty")] IGetAllInputPort getAllInputPort,
                                [FromKeyedServices("GetAllPropertyType")] IGetAllInputPort getAllTypeInputPort,
                                [FromKeyedServices("GetAllOwnerForProperty")] IGetAllInputPort getAllOwnerInputPort,
                                ICreateInputPort<CreatePropertyDTO> createInputPort,
                                IUpdateInputPort<UpdatePropertyDTO> updateInputPort,
                                [FromKeyedServices("DeleteProperty")] IDeleteInputPort deleteInputPort,
                                IOutputPort outputPort) : Controller
{
    public async Task<IActionResult> Index()
    {
        // Initialize view model
        PropertyViewModel model = new();

        // Get data
        IOperationResponse response = await GetAllPropertyController.Handle(getAllInputPort, outputPort);

        // Validate if are any errors
        if (response.StatusCode != ResponseStatus.Success) model.Response = response;
        model.Properties = response.Content as IReadOnlyList<GetAllPropertyDTO> ?? [];

        response = await GetAllPropertyTypeController.Handle(getAllTypeInputPort, outputPort);

        // Validate if are any errors
        if (response.StatusCode != ResponseStatus.Success) model.Response = response;
        model.PropertyTypeList = response.Content as IReadOnlyList<GetAllPropertyTypeDTO> ?? [];

        response = await GetAllOwnerForPropertyController.Handle(getAllOwnerInputPort, outputPort);

        // Validate if are any errors
        if (response.StatusCode != ResponseStatus.Success) model.Response = response;
        model.OwnerList = response.Content as IReadOnlyList<GetAllOwnerForPropertyDTO> ?? [];

        // Validate if alert exist
        if (TempData["alert"] is not null)
        {
            var alert = JsonConvert.DeserializeObject<OperationResponseVO>((string)TempData["alert"]);
            model.Response = alert;
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Create(PropertyViewModel model)
    {
        IOperationResponse response;

        // Validate data
        if (!ModelState.IsValid)
        {
            response = new OperationResponseVO
            {
                StatusCode = ResponseStatus.Warning,
                Message = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).FirstOrDefault()
            };
        }
        else
        {
            response = await CreatePropertyController.Handle(model.PropertyObj,
                                                             createInputPort,
                                                             outputPort);
        }

        if (response.StatusCode == ResponseStatus.Success)
        {
            TempData["alert"] = JsonConvert.SerializeObject(response);
            return RedirectToAction("Index");
        }

        model.Response = response;

        return View("Index", model);
    }

    [HttpPost]
    public async Task<IActionResult> Update(PropertyViewModel model)
    {
        IOperationResponse response;

        // Validate data
        if (!ModelState.IsValid)
        {
            response = new OperationResponseVO
            {
                StatusCode = ResponseStatus.Warning,
                Message = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).FirstOrDefault()
            };
        }
        else
        {
            response = await UpdatePropertyController.Handle(model.PropertyUpdateObj,
                                                             updateInputPort,
                                                             outputPort);
        }

        return Json(new
        {
            message = response.Message,
            status = response.StatusCode.ToString()
        });
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int propertyId)
    {
        IOperationResponse response = await DeletePropertyController.Handle(propertyId,
                                                                            deleteInputPort,
                                                                            outputPort);

        TempData["alert"] = JsonConvert.SerializeObject(response);
        return RedirectToAction("Index");
    }
}