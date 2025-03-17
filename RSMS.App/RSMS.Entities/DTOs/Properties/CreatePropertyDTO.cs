namespace RSMS.Entities.DTOs.Properties;
public class CreatePropertyDTO(byte propertyTypeId, int ownerId,
                               string number, string address, decimal area,
                               decimal? constructionArea)
{
    public byte PropertyTypeId => propertyTypeId;
    public int OwnerId => ownerId;
    public string Number => number;
    public string Address => address;
    public decimal Area => area;
    public decimal? ConstructionArea => constructionArea;
}