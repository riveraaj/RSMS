namespace RSMS.Entities.DTOs.Properties.PropertyTypes;
public class UpdatePropertyTypeDTO(byte id, string description)
{
    public byte Id => id;
    public string Description => description;
}