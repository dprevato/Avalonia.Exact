namespace DataServices.Configurations;
public class AgentMap : IEntityTypeConfiguration<Agent>
{
    public void Configure(EntityTypeBuilder<Agent> e) {
        e.HasKey(x => x.Guid);
        e.HasIndex(x => new { x.Cid, x.LoginName, x.FirstLogon }).HasDatabaseName("Cid_LoginName_idx").IsUnique();
        e.HasIndex(x => new { x.LoginName, x.Cid, x.FirstLogon }).HasDatabaseName("LoginName_Cid_idx").IsUnique();
        e.Property(x => x.Grant).HasConversion<string>();
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Employee).WithMany(x => x.Agents).HasForeignKey(x => x.Cid);
    }
}