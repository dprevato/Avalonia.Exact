namespace DataServices.Configurations;
public class RegionMap : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.Id).HasMaxLength(1); // Secondo la codifica, consente 30 zone differenti. Più che sufficienti a meno di richieste specifiche
        e.Property(x => x.Version).IsRowVersion();
    }
}