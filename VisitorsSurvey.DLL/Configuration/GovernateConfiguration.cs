using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Configuration
{
    public class GovernateConfiguration : IEntityTypeConfiguration<Governate>
    {
        public void Configure(EntityTypeBuilder<Governate> builder)
        {
            builder.ToTable("Governate", "dbo");
            builder.HasKey(e => e.GovernateCode);
            builder.Property(e => e.Name).IsRequired(true);
            builder.Property(e => e.ArabicName).IsRequired(true);


            builder.HasOne(d => d.RegionNavigation)
            .WithMany(r => r.GovernateNavigation)
            .HasForeignKey(d => d.RegionCode)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
