using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Configuration
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("Region", "dbo");
            builder.HasKey(e => e.RegionCode);
            builder.Property(e => e.Name).IsRequired(true);
            builder.Property(e => e.ArabicName).IsRequired(true);


        }
    }
}
