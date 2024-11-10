using Microsoft.EntityFrameworkCore;

namespace DataModel.Model;

// KindMaster rappresenta una View nel database che restituisce gli elementi Kind di primo livello, quelli che terminano per '0'

[Keyless]
public class KindMaster
{
    public required string Id { get; set; }
    public required string Name { get; set; }
}

// KindDetail rappresenta una View nel database che restituisce gli elementi Kind di secondo livello, ovvero quelli che NON terminano per '0'

[Keyless]
public class KindDetail
{
    public required string Id { get; set; }
    public required string Name { get; set; }
}