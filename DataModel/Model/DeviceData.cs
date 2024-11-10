namespace DataModel.Model;
public class DeviceData
{
    public required string DeviceCode { get; set; }
    public required int ItemNo { get; set; }
    public string? ItemUnit { get; set; }
    public required string ItemName { get; set; }
    public required string ItemValue { get; set; }
    public required DateTime Version { get; set; }

    public Device? Device { get; set; }
}
