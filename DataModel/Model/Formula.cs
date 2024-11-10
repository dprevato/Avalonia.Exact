namespace DataModel.Model;
public class Formula
{
    public required int Id { get; set; }
    public required string Template { get; set; } // testo della formula, con segnaposti per i parametri
    public int? ArgsCount { get; set; } // numero di parametri richiesto dalla formula
    public required DateTime Version { get; set; }

    public virtual ObservableCollection<Pm>? Pms { get; set; } = [];
}
