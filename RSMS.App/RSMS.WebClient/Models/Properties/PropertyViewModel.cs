namespace RSMS.WebClient.Models.Properties;
public class PropertyViewModel : BaseViewModel
{
    public IReadOnlyList<GetAllPropertyDTO> Properties { get; set; }
    public IReadOnlyList<GetAllPropertyTypeDTO> PropertyTypeList { get; set; }
    public IReadOnlyList<GetAllOwnerForPropertyDTO> OwnerList { get; set; }
    public CreatePropertyDTO PropertyObj { get; set; }
    public UpdatePropertyDTO PropertyUpdateObj { get; set; }

    public PropertyViewModel()
    {
        Title = "Property";
        Properties = [];
        PropertyTypeList = [];
        OwnerList = [];
    }

    public List<SelectListItem> PropertyTypes => PropertyTypeList.Select(p => new SelectListItem
    {
        Value = p.Id.ToString(),
        Text = p.Description,
    }).ToList();

    public List<SelectListItem> Owners => OwnerList.Select(p => new SelectListItem
    {
        Value = p.Id.ToString(),
        Text = $"{p.IdentificationNumber} | {p.Name}",
    }).ToList();
}