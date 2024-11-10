namespace DataServices.Configurations;
public class JournalMap : IEntityTypeConfiguration<Journal>
{
    public void Configure(EntityTypeBuilder<Journal> e) {
        e.HasKey(x => x.Id);
        e.HasIndex(x => new { x.PlantCode, x.EntryDate }).HasDatabaseName("plant_entry_idx").IsUnique(false); // possono esistere scritture pari impianto, pari data
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Plant).WithMany(x => x.Journal).HasForeignKey(x => x.PlantCode);
    }
}