using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using stf.Domain;


public class PlanetConfiguration : IEntityTypeConfiguration<Planet>
{
    public void Configure(EntityTypeBuilder<Planet> builder)
    {
        builder.ToTable("Planet");
        builder.HasKey(p => p.PlanetId);
        builder.Property(p => p.PlanetId).UseIdentityColumn(100, 100).ValueGeneratedOnAdd();
        builder.Property(p => p.Name).HasMaxLength(50);
        builder.Property(p => p.Description).HasMaxLength(500);
    }
}
