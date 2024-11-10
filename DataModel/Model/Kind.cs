namespace DataModel.Model;
public class Kind
{
    public required string Id { get; set; }
    public required string Name { get; set; }

    public virtual ObservableCollection<Device> Devices { get; set; } = [];
}
