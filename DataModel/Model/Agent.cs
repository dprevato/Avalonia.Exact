using DataModel.Enums;

namespace DataModel.Model;

public class Agent
{
    public Guid Guid { get; set; }
    public required string Cid { get; set; } // matricola Employee.cid
    public required string LoginName { get; set; }
    public Grants Grant { get; set; }
    public DateTime? FirstLogon { get; set; }
    public DateTime? LatestLogon { get; set; }
    public DateTime? LastLogon { get; set; } // Se è caricato, l'utente non può più accedere se non come guest
    public required DateTime Version { get; set; }

    public virtual Employee? Employee { get; set; }
}