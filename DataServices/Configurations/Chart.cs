namespace DataServices.Configurations;
public class ChartMap : IEntityTypeConfiguration<Chart>
{
    public void Configure(EntityTypeBuilder<Chart> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.Title).IsRequired();
        e.Property(x => x.ShowLegend).HasDefaultValue(false);
        e.Property(x => x.Author).HasDefaultValue("PUBLIC");
        e.Property(x => x.ShowLegend).HasDefaultValue(false);
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.ChartCollection).WithMany(x => x.Charts).HasForeignKey(x => x.ChartCollectionId);
        e.HasMany(x => x.YAxis).WithOne(x => x.Chart).HasForeignKey(x => x.ChartId);
        e.HasMany(x => x.Plot).WithOne(x => x.Chart).HasForeignKey(x => x.ChartId);
        e.HasMany(x => x.Annotations).WithOne(x => x.Chart).HasForeignKey(x => x.ChartId);
    }
}