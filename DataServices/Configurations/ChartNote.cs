namespace DataServices.Configurations;
public class ChartNoteMap : IEntityTypeConfiguration<ChartNote>
{
    public void Configure(EntityTypeBuilder<ChartNote> e) {
        e.HasKey(x => new { x.ChartId, x.Id });
        e.Property(x => x.Id).ValueGeneratedNever();
        e.Property(x => x.XPos).IsRequired(false);
        e.Property(x => x.YPos).IsRequired(false);
        e.Property(x => x.NoteColor).IsRequired(false);
        e.Property(x => x.NoteText).IsRequired(false);
        e.Property(x => x.NoteAlignment).IsRequired().HasConversion<string>();
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Chart).WithMany(x => x.Annotations).HasForeignKey(x => x.ChartId);
        e.HasOne(x => x.YAxis).WithMany(x => x.Annotations).HasForeignKey(x => new { x.YAxisId, x.Id });
        e.HasOne(x => x.Plot).WithMany(x => x.Annotations).HasForeignKey(x => new { x.ChartId, x.Id });
    }
}