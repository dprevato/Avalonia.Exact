namespace DataServices.Configurations;
public class DeviceDataMap : IEntityTypeConfiguration<DeviceData>
{
    public void Configure(EntityTypeBuilder<DeviceData> e) {
        e.HasKey(x => new { x.DeviceCode, x.ItemNo });
        e.Property(x => x.ItemNo).ValueGeneratedOnAdd();
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Device).WithMany(x => x.DevDataItems).HasForeignKey(x => x.DeviceCode);
    }
}