namespace RSMS.BusinessObjects.POCOs.Properties;
public class PropertyTypePOCO
{
    public short PropertyTypeId { get; set; }
    public string Description { get; set; }

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