namespace RSMS.Repositories.Repositories.Owners;
internal class OwnerCommandsRepository(IOwnerCommandsDataContext context) : IOwnerRepository
{
    private readonly IOwnerCommandsDataContext _context = context;

    public async Task<IEnumerable<GetAllOwnerDTO>> GetAllAsync()
    {
        IEnumerable<OwnerPOCO> owners = await _context.GetAllAsync();

        return [.. owners.Select(o => new GetAllOwnerDTO(o.OwnerId,
                                                         o.Name,
                                                         o.Telephone,
                                                         o.Email,
                                                         o.IdentificationNumber,
                                                         o.Address))];
    }

    public async Task<IEnumerable<GetAllOwnerForPropertyDTO>> GetAllForPropertyAsync()
    {
        IEnumerable<OwnerPOCO> owners = await _context.GetAllAsync();

        return [.. owners.Select(o => new GetAllOwnerForPropertyDTO(o.OwnerId,
                                                                    o.Name,
                                                                    o.IdentificationNumber))];
    }

    public async Task<bool> CreateAsync(CreateOwnerDTO oCreateOwnerDTO)
    {
        OwnerPOCO owner = OwnerPOCO.MapFrom(oCreateOwnerDTO);

        return await _context.CreateAsync(owner);
    }

    public async Task<bool> UpdateAsync(UpdateOwnerDTO oUpdateOwnerDTO)
    {
        OwnerPOCO owner = OwnerPOCO.MapFrom(oUpdateOwnerDTO);

        return await _context.UpdateAsync(owner);
    }

    public async Task<bool> DeleteAsync(int id) => await _context.DeleteAsync(id);

}