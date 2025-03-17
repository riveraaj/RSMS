namespace RSMS.BusinessObjects.Interfaces.Repositories.Owners;
public interface IOwnerRepository
{
    Task<IEnumerable<GetAllOwnerDTO>> GetAllAsync();
    Task<IEnumerable<GetAllOwnerForPropertyDTO>> GetAllForPropertyAsync();
    Task<bool> CreateAsync(CreateOwnerDTO oCreateOwnerDTO);
    Task<bool> UpdateAsync(UpdateOwnerDTO oUpdateOwnerDTO);
    Task<bool> DeleteAsync(int id);
}