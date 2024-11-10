namespace DataServices.Configurations;
public class ChartPlotMap : IEntityTypeConfiguration<ChartPlot>
{
    public void Configure(EntityTypeBuilder<ChartPlot> e) {
        e.HasKey(x => new { x.ChartId, x.Id });
        e.Property(x => x.Id).ValueGeneratedNever();
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Chart).WithMany(x => x.Plot).HasForeignKey(x => x.ChartId);
        e.HasOne(x => x.YAxis).WithMany(x => x.Plot).HasForeignKey(x => new { x.YAxisId, x.Id });
    }
}