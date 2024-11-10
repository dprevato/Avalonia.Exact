namespace DataServices.Configurations;
public class ArgumentMap : IEntityTypeConfiguration<Argument>
{
    public void Configure(EntityTypeBuilder<Argument> e) {
        e.HasKey(x => x.Id);
        e.HasIndex(x => new { x.PmCode, x.ArgPos }).HasDatabaseName("Argument_code_pos_idx").IsUnique();
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Pm).WithMany(x => x.FormulaArguments).HasForeignKey(x => x.PmCode);
    }
}