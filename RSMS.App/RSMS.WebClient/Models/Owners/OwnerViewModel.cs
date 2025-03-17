namespace RSMS.WebClient.Models.Owners;
public class OwnerViewModel : BaseViewModel
{
    public IReadOnlyList<GetAllOwnerDTO> Owners { get; set; }
    public CreateOwnerDTO OwnerObj { get; set; }
    public UpdateOwnerDTO OwnerUpdateObj { get; set; }

    public OwnerViewModel()
    {
        Title = "Owner";
        Owners = [];
    }
}