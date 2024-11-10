namespace DataModel.Model;
public class Journal
{
    public required long Id { get; set; }
    public required string PlantCode { get; set; }
    public required DateTime EntryDate { get; set; }
    public required string EntryText { get; set; }
    public required DateTime Version { get; set; }
    public virtual Plant? Plant { get; set; }
}
