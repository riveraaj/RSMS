namespace RSMS.Entities.DTOs.Owners;
public class GetAllOwnerForPropertyDTO(string name, string identificationNumber)
{
    public string Name => name;
    public string IdentificationNumber => identificationNumber;
}