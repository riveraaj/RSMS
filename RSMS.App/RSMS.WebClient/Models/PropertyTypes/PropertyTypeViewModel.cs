using RSMS.Entities.DTOs.Properties.PropertyTypes;
using RSMS.WebClient.Models.Bases;

namespace RSMS.WebClient.Models.PropertyTypes;
public class PropertyTypeViewModel : BaseViewModel
{
    public List<GetAllPropertyTypeDTO> PropertyTypes { get; set; }
    public CreatePropertyTypeDTO PropertyTypeObj { get; set; }
    public UpdatePropertyTypeDTO PropertyTypeUpdateObj { get; set; }

    public PropertyTypeViewModel()
    {
        this.Title = "Property Type";
        PropertyTypes = [];
    }
}