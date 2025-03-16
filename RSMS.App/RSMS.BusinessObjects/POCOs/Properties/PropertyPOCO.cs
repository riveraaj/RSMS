namespace RSMS.BusinessObjects.POCOs.Properties;
public class PropertyPOCO
{
    public int PropertyId { get; set; }
    public short PropertyTypeId { get; set; }
    public int OwnerId { get; set; }
    public string Number { get; set; }
    public string Address { get; set; }
    public float Area { get; set; }
    public float ConstructionArea { get; set; }
}