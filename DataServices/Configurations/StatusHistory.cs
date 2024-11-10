namespace DataServices.Configurations;
public class StatusHistoryMap : IEntityTypeConfiguration<StatusHistory>
{
    public void Configure(EntityTypeBuilder<StatusHistory> e) {
        e.HasKey(x => x.Guid);
        e.Property(x => x.Guid).ValueGeneratedOnAdd();
        e.HasIndex(x => new { x.PmCode, x.NewDate }).IsUnique().HasDatabaseName("pmcode_newdate_idx");
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Pm).WithMany(x => x.StatusHistory).HasForeignKey(x => x.PmCode);
    }
}