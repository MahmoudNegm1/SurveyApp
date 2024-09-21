using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Configuration
{
    public class VisitorReviewDetailConfiguration : IEntityTypeConfiguration<VisitorReviewDetail>
    {
        public void Configure(EntityTypeBuilder<VisitorReviewDetail> builder)
        {
            builder.ToTable("VisitorReviewDetail", "dbo");
            builder.HasKey(e => e.VisitorReviewDetailCode);

            builder.HasOne(d => d.VisitorReviewNavigation)
                   .WithMany(r => r.VisitorReviewDetail)
                   .HasForeignKey(d => d.VisitorReviewCode)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
