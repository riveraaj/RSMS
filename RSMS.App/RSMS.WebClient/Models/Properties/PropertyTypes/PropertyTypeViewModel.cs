namespace RSMS.WebClient.Models.Properties.PropertyTypes;
public class PropertyTypeViewModel : BaseViewModel
{
    public IReadOnlyList<GetAllPropertyTypeDTO> PropertyTypes { get; set; }
    public CreatePropertyTypeDTO PropertyTypeObj { get; set; }
    public UpdatePropertyTypeDTO PropertyTypeUpdateObj { get; set; }

    public PropertyTypeViewModel()
    {
        Title = "Property Type";
        PropertyTypes = [];
    }
}