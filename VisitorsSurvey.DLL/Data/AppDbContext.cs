using Microsoft.EntityFrameworkCore;
using VisitorsSurvey.DLL.Configuration;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Park> Parks { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Governate> Governates { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<VisitorReviewItem> VisitorReviewItems { get; set; }
        public virtual DbSet<VisitorReview> VisitorReviews { get; set; }
        public virtual DbSet<VisitorReviewDetail> VisitorReviewDetails { get; set; }

        public virtual DbSet<WeekDay> WeekDays { get; set; }
        public virtual DbSet<YearMonth> yearMonths { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new ParkConfiguration());
            modelBuilder.ApplyConfiguration(new GovernateConfiguration());
            modelBuilder.ApplyConfiguration(new VisitorReviewConfiguration());
            modelBuilder.ApplyConfiguration(new VisitorReviewDetailConfiguration());
            modelBuilder.ApplyConfiguration(new RateConfiguration());
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new VisitorReviewItemConfiguration());
            modelBuilder.ApplyConfiguration(new WeekDayConfiguration());
            modelBuilder.ApplyConfiguration(new YearMonthConfiguration());
        }
    }
}
