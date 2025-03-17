namespace RSMS.BusinessObjects.POCOs.Properties;
public class PropertyTypePOCO
{
    public byte PropertyTypeId { get; set; }
    public string Description { get; set; } = null!;

    public static PropertyTypePOCO MapFrom(CreatePropertyTypeDTO oCreatePropertyTypeDTO)
        => new()
        {
            Description = oCreatePropertyTypeDTO.Description
        };

    public static PropertyTypePOCO MapFrom(UpdatePropertyTypeDTO oUpdatePropertyTypeDTO)
    => new()
    {
        PropertyTypeId = oUpdatePropertyTypeDTO.Id,
        Description = oUpdatePropertyTypeDTO.Description
    };
}