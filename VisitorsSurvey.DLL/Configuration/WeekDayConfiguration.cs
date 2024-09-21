using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Configuration
{
    public class WeekDayConfiguration : IEntityTypeConfiguration<WeekDay>
    {
        public void Configure(EntityTypeBuilder<WeekDay> builder)
        {
            builder.ToTable("WeekDay", "dbo");
            builder.HasKey(e => e.WeekDayCode);
            builder.Property(e => e.Name).IsRequired(true);
            builder.Property(e => e.ArabicName).IsRequired(true);



        }
    }
}
