namespace DataServices.Configurations;

public class RoleMap : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> e) {
        e.HasKey(x => x.Id);
    }
}