namespace DataServices.Configurations;
public class KindMap : IEntityTypeConfiguration<Kind>
{
    public void Configure(EntityTypeBuilder<Kind> e) {
        e.HasKey(x => x.Id);
    }
}