namespace DataServices.Configurations;
public class WardenMap : IEntityTypeConfiguration<Warden>
{
    public void Configure(EntityTypeBuilder<Warden> e) {
        e.HasKey(x => x.Guid);
        e.HasIndex(x => new { x.PlantId, x.EmployeeId, x.OnDuty }).HasDatabaseName("Plant_Warden_idx").IsUnique();
        e.HasIndex(x => new { x.EmployeeId, x.PlantId, x.OnDuty }).HasDatabaseName("Warden_Plant_idx").IsUnique();
        e.Property(x => x.RoleId).HasConversion<string>();
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Plant).WithMany(x => x.Wardens).HasForeignKey(x => x.PlantId);
        e.HasOne(x => x.Employee).WithMany(x => x.Wardens).HasForeignKey(x => x.EmployeeId);
    }
}