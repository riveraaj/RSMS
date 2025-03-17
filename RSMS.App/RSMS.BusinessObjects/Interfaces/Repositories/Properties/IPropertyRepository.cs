namespace RSMS.BusinessObjects.Interfaces.Repositories.Properties;
public interface IPropertyRepository
{
    Task<IEnumerable<GetAllPropertyDTO>> GetAllAsync();
    Task<bool> CreateAsync(CreatePropertyDTO oCreatePropertyDTO);
    Task<bool> UpdateAsync(UpdatePropertyDTO oUpdatePropertyDTO);
    Task<bool> DeleteAsync(int id);
}