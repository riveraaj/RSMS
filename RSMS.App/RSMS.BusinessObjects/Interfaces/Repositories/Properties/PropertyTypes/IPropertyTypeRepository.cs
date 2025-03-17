namespace RSMS.BusinessObjects.Interfaces.Repositories.Properties.PropertyTypes;
public interface IPropertyTypeRepository
{
    Task<IEnumerable<GetAllPropertyTypeDTO>> GetAllAsync();
    Task<bool> CreateAsync(CreatePropertyTypeDTO oCreatePropertyTypeDTO);
    Task<bool> UpdateAsync(UpdatePropertyTypeDTO oUpdatePropertyTypeDTO);
    Task<bool> DeleteAsync(int id);
}