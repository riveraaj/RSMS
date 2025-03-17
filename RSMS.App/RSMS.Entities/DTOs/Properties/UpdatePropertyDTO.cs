﻿namespace RSMS.Entities.DTOs.Properties;
public class UpdatePropertyDTO
{
    public int Id { get; set; }
    public byte PropertyTypeId { get; set; }
    public int OwnerId { get; set; }
    public string Number { get; set; } = null!;
    public string Address { get; set; } = null!;
    public decimal Area { get; set; }
    public decimal? ConstructionArea { get; set; }
}