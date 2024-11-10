using DataModel.Enums;

namespace DataModel.Model;

public class ChartNote
{
    public required Guid Guid { get; set; }
    public required int ChartId { get; set; }
    public required int Id { get; set; }
    public required int YAxisId { get; set; }
    public required int PlotId { get; set; }
    public DateTime? XPos { get; set; }
    public double? YPos { get; set; }
    public string? NoteColor { get; set; }
    public string? NoteText { get; set; }
    public Alignments NoteAlignment { get; set; }
    public required DateTime Version { get; set; }

    public virtual Chart? Chart { get; set; }
    public virtual ChartYAxis? YAxis { get; set; }
    public virtual ChartPlot? Plot { get; set; }
}