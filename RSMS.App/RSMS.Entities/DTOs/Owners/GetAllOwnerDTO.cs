namespace RSMS.Entities.DTOs.Owners;
public class GetAllOwnerDTO(int id, string name, string telephone,
                            string? email, string identificationNumber,
                            string? address)
{
    public int Id => id;
    public string Name => name;
    public string Telephone => telephone;
    public string? Email => email;
    public string IdentificationNumber => identificationNumber;
    public string? Address => address;
}