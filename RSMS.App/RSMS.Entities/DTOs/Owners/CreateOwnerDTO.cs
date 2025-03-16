namespace RSMS.Entities.DTOs.Owners;
public class CreateOwnerDTO(string name, string telephone,
                            string email, string identificationNumber,
                            string address)
{
    public string Name => name;
    public string Telephone => telephone;
    public string Email => email;
    public string IdentificationNumber => identificationNumber;
    public string Address => address;
}