namespace RSMS.Entities.DTOs.Owners;
public class GetAllOwnerForPropertyDTO(int id, string name, string identificationNumber)
{
    public int Id => id;
    public string Name => name;
    public string IdentificationNumber => identificationNumber;
}