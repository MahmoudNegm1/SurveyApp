using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Configuration
{
    public class VisitorReviewItemConfiguration : IEntityTypeConfiguration<VisitorReviewItem>
    {
        public void Configure(EntityTypeBuilder<VisitorReviewItem> builder)
        {
            builder.ToTable("VisitorReviewItem", "dbo");
            builder.HasKey(e => e.VisitorReviewItemCode);
            builder.Property(e => e.Name).IsRequired(true);
            builder.Property(e => e.ArabicName).IsRequired(true);



        }
    }
}
