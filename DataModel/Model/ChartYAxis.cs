namespace DataModel.Model;

public class ChartYAxis
{
    public required int ChartId { get; set; }
    public required int Id { get; set; }
    public required int PlotId { get; set; }
    public string? Title { get; set; }
    public double? MinValue { get; set; }
    public double? MaxValue { get; set; }
    public required DateTime Version { get; set; }

    public virtual Chart? Chart { get; set; }
    public virtual ObservableCollection<ChartPlot>? Plot { get; set; }
    public virtual ObservableCollection<ChartNote>? Annotations { get; set; }
}