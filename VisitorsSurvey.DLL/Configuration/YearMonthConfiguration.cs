using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Configuration
{
    public class YearMonthConfiguration : IEntityTypeConfiguration<YearMonth>
    {
        public void Configure(EntityTypeBuilder<YearMonth> builder)
        {
            builder.ToTable("YearMonth", "dbo");
            builder.HasKey(e => e.YearMonthCode);
            builder.Property(e => e.Name).IsRequired(true);
            builder.Property(e => e.ArabicName).IsRequired(true);
        }
    }
}
