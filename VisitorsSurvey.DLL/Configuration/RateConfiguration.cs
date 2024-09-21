using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Configuration
{
    public class RateConfiguration : IEntityTypeConfiguration<Rate>
    {
        public void Configure(EntityTypeBuilder<Rate> builder)
        {
            builder.ToTable("Rate", "dbo");
            builder.HasKey(e => e.RateCode);
            builder.Property(e => e.Name).IsRequired(true);
            builder.Property(e => e.ArabicName).IsRequired(true);



        }
    }
}
