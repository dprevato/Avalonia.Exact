namespace DataModel.Model;
public class Region
{
    public required string Id { get; set; }
    public required string Name { get; set; } // nome breve
    public string? Details { get; set; } // Nome esteso, descrizione
    public required DateTime Version { get; set; } // TimeStamp

    public virtual ObservableCollection<Plant>? Plants { get; set; } = [];
    public virtual ObservableCollection<Device>? Devices { get; set; } = [];
    public virtual ObservableCollection<Employee>? Employees { get; set; } = [];
}
