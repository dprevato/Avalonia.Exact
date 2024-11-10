namespace DataModel.Model;
public class Employee
{
    public Guid Guid { get; set; }
    public required string Cid { get; set; } // Matricola
    public string? Title { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? FirstName { get; set; }
    public string? Boss { get; set; }               // Id del superiore diretto
    public string? RoleId { get; set; }
    public required string RegionId { get; set; } // Foreign Key: Region.Id
    public required DateOnly Hired { get; set; }
    public DateOnly? Retired { get; set; }
    public required DateTime Version { get; set; } // Timestamp

    public virtual Region? Region { get; set; }
    public virtual Role? Role { get; set; }
    public virtual ObservableCollection<Warden>? Wardens { get; set; }
    public virtual ObservableCollection<Agent>? Agents { get; set; }
}
