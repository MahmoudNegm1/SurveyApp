using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City", "dbo");
            builder.HasKey(e => e.CityCode);
            builder.Property(e => e.Name).IsRequired(true);
            builder.Property(e => e.ArabicName).IsRequired(true);



            builder.HasOne(d => d.GovernateNavigation)
            .WithMany(r => r.CitiesNavigation)
            .HasForeignKey(d => d.GovernateCode)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
