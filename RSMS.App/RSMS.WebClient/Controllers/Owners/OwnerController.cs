using RSMS.WebClient.Validators.Owners;

namespace RSMS.WebClient.Controllers.Owners;
public class OwnerController([FromKeyedServices("GetAllOwner")] IGetAllInputPort getAllInputPort,
                             ICreateInputPort<CreateOwnerDTO> createInputPort,
                             IUpdateInputPort<UpdateOwnerDTO> updateInputPort,
                             [FromKeyedServices("DeleteOwner")] IDeleteInputPort deleteInputPort,
                             IOutputPort outputPort) : Controller
{
    public async Task<IActionResult> Index()
    {
        // Initialize view model
        OwnerViewModel model = new();

        // Get data
        IOperationResponse response = await GetAllOwnerController.Handle(getAllInputPort, outputPort);

        // Validate if are any errors
        if (response.StatusCode != ResponseStatus.Success) model.Response = response;
        model.Owners = response.Content as IReadOnlyList<GetAllOwnerDTO> ?? [];

        // Validate if alert exist
        if (TempData["alert"] is not null)
        {
            var alert = JsonConvert.DeserializeObject<OperationResponseVO>((string)TempData["alert"]);
            model.Response = alert;
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Create(OwnerViewModel model)
    {
        IOperationResponse response;

        // Validate data
        CreateOwnerValidator validator = new();
        ValidationResult result = validator.Validate(model.OwnerObj);

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
            response = await CreateOwnerController.Handle(model.OwnerObj,
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
    public async Task<IActionResult> Update(OwnerViewModel model)
    {
        IOperationResponse response;

        // Validate data
        UpdateOwnerValidator validator = new();
        ValidationResult result = validator.Validate(model.OwnerUpdateObj);

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
            response = await UpdateOwnerController.Handle(model.OwnerUpdateObj,
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
    public async Task<IActionResult> Delete(int OwnerId)
    {
        IOperationResponse response = await DeleteOwnerController.Handle(OwnerId,
                                                                         deleteInputPort,
                                                                         outputPort);

        TempData["alert"] = JsonConvert.SerializeObject(response);
        return RedirectToAction("Index");
    }
}