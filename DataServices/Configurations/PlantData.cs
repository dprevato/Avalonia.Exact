namespace DataServices.Configurations;
public class PlantDataMap : IEntityTypeConfiguration<PlantData>
{
    public void Configure(EntityTypeBuilder<PlantData> e) {
        e.HasKey(x => new { x.PlantCode, x.ItemNo });
        e.Property(x => x.ItemNo).ValueGeneratedOnAdd();
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Plant).WithMany(x => x.PlantInfo).HasForeignKey(x => x.PlantCode);
    }
}