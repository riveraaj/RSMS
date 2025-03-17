namespace RSMS.Repositories.Repositories.Properties.PropertyTypes;
class PropertyTypeCommandsRepository(IPropertyTypeCommandsDataContext context) : IPropertyTypeRepository
{
    private readonly IPropertyTypeCommandsDataContext _context = context;

    public async Task<IEnumerable<GetAllPropertyTypeDTO>> GetAllAsync()
    {
        IEnumerable<PropertyTypePOCO> properties = await _context.GetAllAsync();

        return [.. properties.Select(p => new GetAllPropertyTypeDTO(p.PropertyTypeId,
                                                                    p.Description))];
    }

    public async Task<bool> CreateAsync(CreatePropertyTypeDTO oCreatePropertyTypeDTO)
    {
        PropertyTypePOCO propertyType = PropertyTypePOCO.MapFrom(oCreatePropertyTypeDTO);

        return await _context.CreateAsync(propertyType);
    }

    public async Task<bool> UpdateAsync(UpdatePropertyTypeDTO oUpdatePropertyTypeDTO)
    {
        PropertyTypePOCO propertyType = PropertyTypePOCO.MapFrom(oUpdatePropertyTypeDTO);

        return await _context.UpdateAsync(propertyType);
    }

    public async Task<bool> DeleteAsync(int id) => await _context.DeleteAsync(id);
}