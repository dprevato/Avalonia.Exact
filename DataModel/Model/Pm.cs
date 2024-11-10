using DataModel.Enums;

namespace DataModel.Model;
public class Pm
{
    public required string DeviceCode { get; set; } // Code è una chiave alternativa per device
    public required string Item { get; set; }
    public string? Code { get; set; } // campo calcolato: DeviceCode + Id
    public required string Tag { get; set; } // codice di targa
    public required string Name { get; set; }
    public required DateOnly PlacementDate { get; set; }
    public DateOnly? DismissionDate { get; set; }
    public PmStates? Status { get; set; }
    public ReportType? Report { get; set; }
    public bool? VirtualPm { get; set; } // il Pm non è fisico
    public bool? Validate { get; set; } // Le misure al Pm devono essere validate
    public double? Offset { get; set; } // quantità fissa da aggiungere alle misure
    public string? Unit { get; set; } // unità di misura
    public bool? AutoImport { get; set; } // Pm ad importazione automatica delle letture da sistema esterno
    public bool? CanImport { get; set; } // Non esistono impedimenti all'importazione delle letture
    public bool? Selected { get; set; } // Il Pm è selezionato per l'importazione delle letture
    public int? FormulaFk { get; set; } // formula di ingegnerizzazione
    public DateOnly? LastImport { get; set; } // data dell'ultima importazione
    public string? SourceTable { get; set; } // Nome della tabella sorgente contenente le misure da preimportare
    public string? SourceFilter { get; set; } // nome del discriminante (tipicamente coincide con il codice Pm)
    public double? AlarmHi { get; set; } // Soglia superiore di allarme
    public double? WarningHi { get; set; } // Soglia superiore di attenzione
    public double? WarningLo { get; set; } // Soglia inferiore di attenzione
    public double? AlarmLo { get; set; } // Soglia inferiore di allarme
    public required DateTime Version { get; set; }

    public virtual ObservableCollection<Argument> FormulaArguments { get; set; } = [];
    public virtual ObservableCollection<Scan>? Scans { get; set; } = [];
    public virtual ObservableCollection<StatusHistory>? StatusHistory { get; set; }
    public virtual Device? Device { get; set; }
    public virtual Formula? Formula { get; set; }
}
