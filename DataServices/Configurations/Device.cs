namespace DataServices.Configurations;
public class DeviceMap : IEntityTypeConfiguration<Device>
{
    public void Configure(EntityTypeBuilder<Device> e) {
        e.HasKey(x => x.DeviceCode);
        e.Property(x => x.PlantCode).IsRequired().HasColumnName("plant");
        e.Property(x => x.KindId).IsRequired().HasColumnName("kind");
        e.Property(x => x.Item).IsRequired();
        e.Property(x => x.DeviceCode).ValueGeneratedOnAdd().HasComputedColumnSql("concat(`plant`,_utf8mb4'.',`kind`,_utf8mb4'.',`item`)", true);
        e.Property(x => x.Tag).IsRequired();
        e.Property(x => x.Name).IsRequired();
        e.Property(x => x.Detail).IsRequired(false);
        e.Property(x => x.Batch).IsRequired(false);
        e.Property(x => x.PlacementDate).IsRequired();
        e.Property(x => x.DismissionDate).IsRequired(false);
        e.Property(x => x.Report).IsRequired(false).HasConversion<string>();
        e.Property(x => x.ValidateReads).HasDefaultValue(false);
        e.Property(x => x.Longitude).HasPrecision(10, 6);
        e.Property(x => x.Latitude).HasPrecision(10, 6);
        e.Property(x => x.Altitude).HasPrecision(10, 3);
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Plant).WithMany(x => x.Devices).HasForeignKey(x => x.PlantCode);
        e.HasOne(x => x.Kind).WithMany(x => x.Devices).HasForeignKey(x => x.KindId);
    }
}