using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Configuration
{
    public class ParkConfiguration : IEntityTypeConfiguration<Park>
    {
        public void Configure(EntityTypeBuilder<Park> builder)
        {
            builder.ToTable("Park", "dbo");
            builder.HasKey(e => e.ParkCode);
            builder.Property(e => e.Name).IsRequired(true);
            builder.Property(e => e.ArabicName).IsRequired(true);

            builder.HasOne(d => d.CityNavigation)
            .WithMany(r => r.ParkNavigation)
            .HasForeignKey(d => d.CityCode)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
