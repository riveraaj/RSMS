namespace RSMS.BusinessObjects.POCOs.Properties;
public class PropertyPOCO
{
    public int PropertyId { get; set; }
    public byte PropertyTypeId { get; set; }
    public int OwnerId { get; set; }
    public string Number { get; set; } = null!;
    public string Address { get; set; } = null!;
    public decimal Area { get; set; }
    public decimal? CosntructionArea { get; set; }

    public static PropertyPOCO MapFrom(CreatePropertyDTO oCreatePropertyDTO)
        => new()
        {
            PropertyTypeId = oCreatePropertyDTO.PropertyTypeId,
            OwnerId = oCreatePropertyDTO.OwnerId,
            Number = oCreatePropertyDTO.Number,
            Address = oCreatePropertyDTO.Address,
            Area = oCreatePropertyDTO.Area,
            CosntructionArea = oCreatePropertyDTO.ConstructionArea,
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
            CosntructionArea = oUpdatePropertyDTO.ConstructionArea,
        };
}