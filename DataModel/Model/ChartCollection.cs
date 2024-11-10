namespace DataModel.Model;

public class ChartCollection
{
    public required int Id { get; set; }
    public required string Code { get; set; }  // Campo calcolato
    public required string PlantId { get; set; }
    public required string KindId { get; set; }
    public required string Title { get; set; } // Nome di ogni grafico che fa parte della serie
    public string? Author { get; set; } // 'public' per default
    public required DateTime Version { get; set; }

    public ObservableCollection<Chart>? Charts { get; set; }
}