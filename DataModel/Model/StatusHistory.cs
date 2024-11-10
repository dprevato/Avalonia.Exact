using DataModel.Enums;

namespace DataModel.Model;
public class StatusHistory
{
    public required Guid Guid { get; set; }
    public required string PmCode { get; set; }
    public required DateOnly NewDate { get; set; }
    public required PmStates NewStatus { get; set; }
    public string? Details { get; set; }
    public required DateTime Version { get; set; }

    public virtual Pm? Pm { get; set; }
}
