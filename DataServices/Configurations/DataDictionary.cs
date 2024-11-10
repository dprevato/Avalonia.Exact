namespace DataServices.Configurations;
public class DataDictionaryMap : IEntityTypeConfiguration<DataDictionary>
{
    public void Configure(EntityTypeBuilder<DataDictionary> e) {
        e.HasKey(x => x.Key);
    }
}