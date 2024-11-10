namespace DataModel.Model;
public class Role
{
    public required string Id { get; set; }
    public required string Name { get; set; }

    public virtual ObservableCollection<Employee>? Employees { get; set; }
}
