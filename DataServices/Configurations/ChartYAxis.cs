namespace DataServices.Configurations;
public class ChartYAxisMap : IEntityTypeConfiguration<ChartYAxis>
{
    public void Configure(EntityTypeBuilder<ChartYAxis> e) {
        e.HasKey(x => new { x.ChartId, x.Id });
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Chart).WithMany(x => x.YAxis).HasForeignKey(x => x.ChartId);
    }
}