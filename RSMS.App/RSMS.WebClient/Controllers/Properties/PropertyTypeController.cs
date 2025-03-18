namespace RSMS.WebClient.Controllers.Properties;
public class PropertyTypeController([FromKeyedServices("GetAllPropertyType")] IGetAllInputPort getAllInputPort,
                                    ICreateInputPort<CreatePropertyTypeDTO> createInputPort,
                                    IUpdateInputPort<UpdatePropertyTypeDTO> updateInputPort,
                                    [FromKeyedServices("DeletePropertyType")] IDeleteInputPort deleteInputPort,
                                    IOutputPort outputPort) : Controller
{
    public async Task<IActionResult> Index()
    {
        // Initialize view model
        PropertyTypeViewModel model = new();

        // Get data
        IOperationResponse response = await GetAllPropertyTypeController.Handle(getAllInputPort, outputPort);

        // Validate if are any errors
        if (response.StatusCode != ResponseStatus.Success) model.Response = response;
        model.PropertyTypes = response.Content as IReadOnlyList<GetAllPropertyTypeDTO> ?? [];

        // Validate if alert exist
        if (TempData["alert"] is not null)
        {
            var alert = JsonConvert.DeserializeObject<OperationResponseVO>((string)TempData["alert"]);
            model.Response = alert;
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Create(PropertyTypeViewModel model)
    {
        IOperationResponse response;

        // Validate data
        CreatePropertyTypeValidator validator = new();
        ValidationResult result = validator.Validate(model.PropertyTypeObj);

        if (!result.IsValid)
        {
            response = new OperationResponseVO
            {
                StatusCode = ResponseStatus.Warning,
                Message = result.Errors.FirstOrDefault().ToString()
            };
        }
        else
        {
            response = await CreatePropertyTypeController.Handle(model.PropertyTypeObj,
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
    public async Task<IActionResult> Update(PropertyTypeViewModel model)
    {
        IOperationResponse response;

        // Validate data
        UpdatePropertyTypeValidator validator = new();
        ValidationResult result = validator.Validate(model.PropertyTypeUpdateObj);

        if (!result.IsValid)
        {
            response = new OperationResponseVO
            {
                StatusCode = ResponseStatus.Warning,
                Message = result.Errors.FirstOrDefault().ToString()
            };
        }
        else
        {
            response = await UpdatePropertyTypeController.Handle(model.PropertyTypeUpdateObj,
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
    public async Task<IActionResult> Delete(int propertyTypeId)
    {
        IOperationResponse response = await DeletePropertyTypeController.Handle(propertyTypeId,
                                                                                deleteInputPort,
                                                                                outputPort);

        TempData["alert"] = JsonConvert.SerializeObject(response);
        return RedirectToAction("Index");
    }
}