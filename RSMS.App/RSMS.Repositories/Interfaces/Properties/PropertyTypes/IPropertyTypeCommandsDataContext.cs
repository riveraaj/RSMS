namespace RSMS.Repositories.Interfaces.Properties.PropertyTypes;
public interface IPropertyTypeCommandsDataContext
{
    Task<IEnumerable<PropertyTypePOCO>> GetAllAsync();
    Task<bool> CreateAsync(PropertyTypePOCO oPropertyTypePOCO);
    Task<bool> UpdateAsync(PropertyTypePOCO oPropertyTypePOCO);
    Task<bool> DeleteAsync(int id);
}