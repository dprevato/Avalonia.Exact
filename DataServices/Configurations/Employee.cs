namespace DataServices.Configurations;

public class EmployeeMap : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> e) {
        e.HasKey(x => x.Cid);
        e.Property(x => x.Cid).HasMaxLength(16); // può contenere un codice fiscale
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Region).WithMany(x => x.Employees).HasForeignKey(x => x.RegionId);
        e.HasOne(x => x.Role).WithMany(x => x.Employees).HasForeignKey(x => x.RoleId);
    }
}
