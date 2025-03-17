namespace RSMS.Entities.DTOs.Owners;
public class UpdateOwnerDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Telephone { get; set; } = null!;
    public string? Email { get; set; }
    public string IdentificationNumber { get; set; } = null!;
    public string? Address { get; set; }
}