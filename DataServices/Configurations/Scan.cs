namespace DataServices.Configurations;
public class ScanMap : IEntityTypeConfiguration<Scan>
{
    public void Configure(EntityTypeBuilder<Scan> e) {
        e.HasKey(x => x.Guid);
        e.Property(x => x.Guid).ValueGeneratedOnAdd();
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Pm).WithMany(x => x.Scans).HasForeignKey(x => x.PmCode);
    }
}