namespace RSMS.DataContext.EFCore.Services;
internal class PropertyTypeCommandsDataContext(RealStateDBContext context) : IPropertyTypeCommandsDataContext
{
    private readonly RealStateDBContext _context = context;

    public async Task<IEnumerable<PropertyTypePOCO>> GetAllAsync()
        => await _context.PropertyTypes.ToListAsync();

    public async Task<bool> CreateAsync(PropertyTypePOCO oPropertyTypePOCO)
    {
        await _context.PropertyTypes.AddAsync(oPropertyTypePOCO);

        int affectedRows = await _context.SaveChangesAsync();
        return affectedRows > 0;
    }

    public async Task<bool> UpdateAsync(PropertyTypePOCO oPropertyTypePOCO)
    {
        PropertyTypePOCO propertyType = await _context.PropertyTypes.FindAsync(oPropertyTypePOCO.PropertyTypeId);

        propertyType.Description = oPropertyTypePOCO.Description;

        int affectedRows = await _context.SaveChangesAsync();
        return affectedRows > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        PropertyTypePOCO propertyType = await _context.PropertyTypes.FindAsync(id);
        _context.PropertyTypes.Remove(propertyType);

        int affectedRows = await _context.SaveChangesAsync();
        return affectedRows > 0;
    }
}