namespace DataServices.Configurations;
public class PmMap : IEntityTypeConfiguration<Pm>
{
    public void Configure(EntityTypeBuilder<Pm> e) {
        e.HasKey(x => x.Code);
        e.Property(x => x.Item).IsRequired().HasMaxLength(1); // Max 36 elementi
        e.Property(x => x.Code).ValueGeneratedOnAdd().HasComputedColumnSql("CONCAT(DeviceCode,'.',Item)", true);
        e.Property(x => x.Status).HasConversion<string>();
        e.Property(x => x.Report).HasConversion<string>();
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Device).WithMany(x => x.Pms).HasForeignKey(x => x.DeviceCode);
        e.HasOne(x => x.Formula).WithMany(x => x.Pms).HasForeignKey(x => x.FormulaFk);
    }
}