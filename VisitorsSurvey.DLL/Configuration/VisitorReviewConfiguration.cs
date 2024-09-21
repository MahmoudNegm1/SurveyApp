using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Configuration
{
    public class VisitorReviewConfiguration : IEntityTypeConfiguration<VisitorReview>
    {
        public void Configure(EntityTypeBuilder<VisitorReview> builder)
        {
            builder.ToTable("VisitorReview", "dbo");
            builder.HasKey(e => e.VisitorReviewCode);
        }
    }
}
