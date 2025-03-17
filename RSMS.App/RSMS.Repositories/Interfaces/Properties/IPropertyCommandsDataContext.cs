namespace RSMS.Repositories.Interfaces.Properties;
public interface IPropertyCommandsDataContext
{
    Task<IEnumerable<PropertyPOCO>> GetAllAsync();
    Task<bool> CreateAsync(PropertyPOCO oPropertyPOCO);
    Task<bool> UpdateAsync(PropertyPOCO oPropertyPOCO);
    Task<bool> DeleteAsync(int id);
}