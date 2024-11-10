namespace DataModel.Model;
public class PlantData
{
    public required string PlantCode { get; set; } // codice impianto
    public required string ItemNo { get; set; } // ordinale 
    public required string ItemName { get; set; }
    public string? ItemUnit { get; set; }
    public required string ItemValue { get; set; }
    public required string Version { get; set; } // timestamp

    public virtual Plant? Plant { get; set; }
}
