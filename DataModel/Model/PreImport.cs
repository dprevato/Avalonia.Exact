namespace DataModel.Model;
public class PreImport
{
    public required string PmCode { get; set; }
    public required DateTime ScanDateTime { get; set; }
    public string? ScanComment { get; set; }
    public required double ScanValue { get; set; }
    public required DateTime Acquisition { get; set; } // data di acquisizione lettura
}