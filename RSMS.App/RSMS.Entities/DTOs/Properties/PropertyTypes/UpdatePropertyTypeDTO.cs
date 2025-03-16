namespace RSMS.Entities.DTOs.Properties.PropertyTypes;
public class UpdatePropertyTypeDTO(short id, string description)
{
    public short Id => id;
    public string Description => description;
}