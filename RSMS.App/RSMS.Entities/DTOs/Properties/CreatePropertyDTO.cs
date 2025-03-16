namespace RSMS.Entities.DTOs.Properties;
public class CreatePropertyDTO(short propertyTypeId, int ownerId,
                               string number, string address, float area,
                               float constructionArea)
{
    public short PropertyTypeId => propertyTypeId;
    public int OwnerId => ownerId;
    public string Number => number;
    public string Address => address;
    public float Area => area;
    public float ConstructionArea => constructionArea;
}