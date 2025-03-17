namespace RSMS.Repositories.Interfaces.Owners;
public interface IOwnerCommandsDataContext
{
    Task<IEnumerable<OwnerPOCO>> GetAllAsync();
    Task<bool> CreateAsync(OwnerPOCO oOwnerPOCO);
    Task<bool> UpdateAsync(OwnerPOCO oOwnerPOCO);
    Task<bool> DeleteAsync(int id);
}