namespace RSMS.DataContext.EFCore.Services;
internal class PropertyCommandsDataContext(RealStateDBContext context) : IPropertyCommandsDataContext
{
    private readonly RealStateDBContext _context = context;

    public async Task<IEnumerable<PropertyPOCO>> GetAllAsync()
        => await _context.Properties.ToListAsync();

    public async Task<bool> CreateAsync(PropertyPOCO oPropertyPOCO)
    {
        await _context.Properties.AddAsync(oPropertyPOCO);

        int affectedRows = await _context.SaveChangesAsync();
        return affectedRows > 0;
    }

    public async Task<bool> UpdateAsync(PropertyPOCO oPropertyPOCO)
    {
        PropertyPOCO property = await _context.Properties.FindAsync(oPropertyPOCO.PropertyId);

        property.Number = oPropertyPOCO.Number;
        property.Address = oPropertyPOCO.Address;
        property.PropertyId = oPropertyPOCO.PropertyId;
        property.Area = oPropertyPOCO.Area;
        property.OwnerId = oPropertyPOCO.OwnerId;
        property.CosntructionArea = oPropertyPOCO.CosntructionArea;

        int affectedRows = await _context.SaveChangesAsync();
        return affectedRows > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        PropertyPOCO property = await _context.Properties.FindAsync(id);
        _context.Properties.Remove(property);

        int affectedRows = await _context.SaveChangesAsync();
        return affectedRows > 0;
    }
}