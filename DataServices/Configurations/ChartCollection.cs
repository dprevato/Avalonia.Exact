namespace DataServices.Configurations;
public class ChartCollectionMap : IEntityTypeConfiguration<ChartCollection>
{
    public void Configure(EntityTypeBuilder<ChartCollection> e) {
        e.ToTable("chart_collection");
        e.HasKey(x => x.Id);
        e.Property(x => x.PlantId).HasColumnName("plant");
        e.Property(x => x.KindId).HasColumnName("kind");
        e.Property(x => x.Code).ValueGeneratedOnAdd().HasComputedColumnSql("concat(`plant`,'.',`kind`,'.',lpad(`id`,3,_utf8mb4'0'))", true);
        e.Property(x => x.Id).ValueGeneratedNever();
        e.Property(x => x.Title).IsRequired();
        e.Property(x => x.Version).IsRowVersion();
    }
}