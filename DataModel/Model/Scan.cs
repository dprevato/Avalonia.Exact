namespace DataModel.Model;
public class Scan  // il nome Reading mi ha sempre fatto cagare, sinceramente
{
    public required Guid Guid { get; set; }
    public required string PmCode { get; set; }
    public required DateOnly ScanDate { get; set; }
    public required TimeOnly ScanTime { get; set; }
    public string? ScanComment { get; set; } // campo descrittivo, usato tradizionalmente per le letture non ingegnerizzate
    public required double ScanValue { get; set; }
    public required DateTime Acquisition { get; set; } // La data di acquisizione non può mancare, per default è la data/ora di inserimento
    public DateTime? Validation { get; set; } // data/ora validazione
    public required DateTime Version { get; set; }

    public virtual Pm? Pm { get; set; }
}
