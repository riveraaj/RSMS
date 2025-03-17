namespace RSMS.BusinessObjects.POCOs.Properties;
public class PropertyPOCO
{
    public int PropertyId { get; set; }
    public short PropertyTypeId { get; set; }
    public int OwnerId { get; set; }
    public string Number { get; set; }
    public string Address { get; set; }
    public float Area { get; set; }
    public float? ConstructionArea { get; set; }

    public static PropertyPOCO MapFrom(CreatePropertyDTO oCreatePropertyDTO)
        => new()
        {
            PropertyTypeId = oCreatePropertyDTO.PropertyTypeId,
            OwnerId = oCreatePropertyDTO.OwnerId,
            Number = oCreatePropertyDTO.Number,
            Address = oCreatePropertyDTO.Address,
            Area = oCreatePropertyDTO.Area,
            ConstructionArea = oCreatePropertyDTO.ConstructionArea,
        };

    public static PropertyPOCO MapFrom(UpdatePropertyDTO oUpdatePropertyDTO)
        => new()
        {
            PropertyId = oUpdatePropertyDTO.Id,
            PropertyTypeId = oUpdatePropertyDTO.PropertyTypeId,
            OwnerId = oUpdatePropertyDTO.OwnerId,
            Number = oUpdatePropertyDTO.Number,
            Address = oUpdatePropertyDTO.Address,
            Area = oUpdatePropertyDTO.Area,
            ConstructionArea = oUpdatePropertyDTO.ConstructionArea,
        };
}