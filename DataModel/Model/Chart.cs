namespace DataModel.Model;

public class Chart
{
    public required int ChartCollectionId { get; set; }
    public required int Id { get; set; }
    public required string Title { get; set; }
    public bool? ShowLegend { get; set; }
    public string? Author { get; set; }
    public required DateTime Version { get; set; }

    public virtual ChartCollection? ChartCollection { get; set; }
    public virtual ObservableCollection<ChartYAxis>? YAxis { get; set; }
    public virtual ObservableCollection<ChartPlot>? Plot { get; set; }
    public virtual ObservableCollection<ChartNote>? Annotations { get; set; }
}