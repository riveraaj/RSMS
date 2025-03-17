using Microsoft.AspNetCore.Mvc;
using RSMS.BusinessObjects.Interfaces.Ports;
using RSMS.Controllers.Properties.PropertyTypes;
using RSMS.Entities.DTOs.Properties.PropertyTypes;
using RSMS.Entities.Enums;
using RSMS.Entities.Interfaces;
using RSMS.WebClient.Models.PropertyTypes;

namespace RSMS.WebClient.Controllers
{
    public class PropertyTypeController([FromKeyedServices("GetAllPropertyType")] IGetAllInputPort getAllInputPort,
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
            model.PropertyTypes = response.Content as List<GetAllPropertyTypeDTO> ?? [];

            return View(model);
        }
    }
}