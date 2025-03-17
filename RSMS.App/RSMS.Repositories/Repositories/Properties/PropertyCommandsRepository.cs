namespace RSMS.Repositories.Repositories.Properties;
internal class PropertyCommandsRepository(IPropertyCommandsDataContext context) : IPropertyRepository
{
    private readonly IPropertyCommandsDataContext _context = context;

    public async Task<IEnumerable<GetAllPropertyDTO>> GetAllAsync()
    {
        IEnumerable<PropertyPOCO> properties = await _context.GetAllAsync();

        return [.. properties.Select(p => new GetAllPropertyDTO(p.PropertyId,
                                                                p.PropertyTypeId,
                                                                p.OwnerId,
                                                                p.Number,
                                                                p.Address,
                                                                p.Area,
                                                                p.ConstructionArea))];
    }

    public async Task<bool> CreateAsync(CreatePropertyDTO oCreatePropertyDTO)
    {
        PropertyPOCO property = PropertyPOCO.MapFrom(oCreatePropertyDTO);

        return await _context.CreateAsync(property);
    }

    public async Task<bool> UpdateAsync(UpdatePropertyDTO oUpdatePropertyDTO)
    {
        PropertyPOCO property = PropertyPOCO.MapFrom(oUpdatePropertyDTO);

        return await _context.UpdateAsync(property);
    }

    public async Task<bool> DeleteAsync(int id) => await _context.DeleteAsync(id);
}