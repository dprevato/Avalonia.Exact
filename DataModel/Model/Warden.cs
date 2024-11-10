namespace DataModel.Model;
public class Warden
{
    public required Guid Guid { get; set; }
    public required string PlantId { get; set; } // codice impianto
    public required string EmployeeId { get; set; } // codice dipendente
    public string? RoleId { get; set; } // default: warden
    public required DateOnly OnDuty { get; set; } // Inizio incarico
    public DateOnly? Retired { get; set; } // termine incarico
    public required DateTime Version { get; set; } // timestamp

    public Plant? Plant { get; set; }
    public Employee? Employee { get; set; }
}
