namespace RSMS.BusinessObjects.POCOs.Owners;
public class OwnerPOCO
{
    public int OwnerId { get; set; }
    public string Name { get; set; }
    public string Telephone { get; set; }
    public string? Email { get; set; }
    public string IdentificationNumber { get; set; }
    public string? Address { get; set; }

    public static OwnerPOCO MapFrom(CreateOwnerDTO oCreateOwnerDTO)
        => new()
        {
            Name = oCreateOwnerDTO.Name,
            Telephone = oCreateOwnerDTO.Telephone,
            Email = oCreateOwnerDTO.Email,
            IdentificationNumber = oCreateOwnerDTO.IdentificationNumber,
            Address = oCreateOwnerDTO.Address
        };

    public static OwnerPOCO MapFrom(UpdateOwnerDTO oUpdateOwnerDTO)
        => new()
        {
            OwnerId = oUpdateOwnerDTO.Id,
            Name = oUpdateOwnerDTO.Name,
            Telephone = oUpdateOwnerDTO.Telephone,
            Email = oUpdateOwnerDTO.Email,
            IdentificationNumber = oUpdateOwnerDTO.IdentificationNumber,
            Address = oUpdateOwnerDTO.Address
        };
}