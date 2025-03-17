namespace RSMS.DataContext.EFCore.Services;
internal class OwnerCommandsDataContext(RealStateDBContext context) : IOwnerCommandsDataContext
{
    private readonly RealStateDBContext _context = context;

    public async Task<IEnumerable<OwnerPOCO>> GetAllAsync()
        => await _context.Owners.ToListAsync();

    public async Task<bool> CreateAsync(OwnerPOCO oOwnerPOCO)
    {
        await _context.Owners.AddAsync(oOwnerPOCO);

        int affectedRows = await _context.SaveChangesAsync();
        return affectedRows > 0;
    }

    public async Task<bool> UpdateAsync(OwnerPOCO oOwnerPOCO)
    {
        OwnerPOCO owner = await _context.Owners.FindAsync(oOwnerPOCO.OwnerId);

        owner.Telephone = oOwnerPOCO.Telephone;
        owner.Email = oOwnerPOCO.Email;
        owner.Address = oOwnerPOCO.Address;
        owner.IdentificationNumber = oOwnerPOCO.IdentificationNumber;
        owner.Name = oOwnerPOCO.Name;

        int affectedRows = await _context.SaveChangesAsync();
        return affectedRows > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        OwnerPOCO owner = await _context.Owners.FindAsync(id);
        _context.Owners.Remove(owner);

        int affectedRows = await _context.SaveChangesAsync();
        return affectedRows > 0;
    }
}