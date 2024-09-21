﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisitorsSurvey.DLL.Data;

#nullable disable

namespace VisitorsSurvey.DLL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.City", b =>
                {
                    b.Property<int>("CityCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityCode"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovernateCode")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityCode");

                    b.HasIndex("GovernateCode");

                    b.ToTable("City", "dbo");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.Governate", b =>
                {
                    b.Property<int>("GovernateCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GovernateCode"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionCode")
                        .HasColumnType("int");

                    b.HasKey("GovernateCode");

                    b.HasIndex("RegionCode");

                    b.ToTable("Governate", "dbo");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.Park", b =>
                {
                    b.Property<int>("ParkCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParkCode"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityCode")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParkCode");

                    b.HasIndex("CityCode");

                    b.ToTable("Park", "dbo");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.Rate", b =>
                {
                    b.Property<int>("RateCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RateCode"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RateCode");

                    b.ToTable("Rate", "dbo");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.Region", b =>
                {
                    b.Property<int>("RegionCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegionCode"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionCode");

                    b.ToTable("Region", "dbo");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.VisitorReview", b =>
                {
                    b.Property<int>("VisitorReviewCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorReviewCode"));

                    b.Property<int>("CityCode")
                        .HasColumnType("int");

                    b.Property<int>("DayOfMonth")
                        .HasColumnType("int");

                    b.Property<int>("GovernateCode")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParkCode")
                        .HasColumnType("int");

                    b.Property<int>("RegionCode")
                        .HasColumnType("int");

                    b.Property<int>("WeekDayName")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("VisitorReviewCode");

                    b.ToTable("VisitorReview", "dbo");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.VisitorReviewDetail", b =>
                {
                    b.Property<int>("VisitorReviewDetailCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorReviewDetailCode"));

                    b.Property<int>("RateCode")
                        .HasColumnType("int");

                    b.Property<int>("VisitorItemCode")
                        .HasColumnType("int");

                    b.Property<int>("VisitorReviewCode")
                        .HasColumnType("int");

                    b.HasKey("VisitorReviewDetailCode");

                    b.HasIndex("VisitorReviewCode");

                    b.ToTable("VisitorReviewDetail", "dbo");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.VisitorReviewItem", b =>
                {
                    b.Property<int>("VisitorReviewItemCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorReviewItemCode"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisitorReviewItemCode");

                    b.ToTable("VisitorReviewItem", "dbo");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.WeekDay", b =>
                {
                    b.Property<int>("WeekDayCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeekDayCode"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeekDayCode");

                    b.ToTable("WeekDay", "dbo");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.YearMonth", b =>
                {
                    b.Property<int>("YearMonthCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YearMonthCode"));

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YearMonthCode");

                    b.ToTable("YearMonth", "dbo");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.City", b =>
                {
                    b.HasOne("VisitorsSurvey.DLL.Entities.Governate", "GovernateNavigation")
                        .WithMany("CitiesNavigation")
                        .HasForeignKey("GovernateCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GovernateNavigation");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.Governate", b =>
                {
                    b.HasOne("VisitorsSurvey.DLL.Entities.Region", "RegionNavigation")
                        .WithMany("GovernateNavigation")
                        .HasForeignKey("RegionCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("RegionNavigation");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.Park", b =>
                {
                    b.HasOne("VisitorsSurvey.DLL.Entities.City", "CityNavigation")
                        .WithMany("ParkNavigation")
                        .HasForeignKey("CityCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CityNavigation");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.VisitorReviewDetail", b =>
                {
                    b.HasOne("VisitorsSurvey.DLL.Entities.VisitorReview", "VisitorReviewNavigation")
                        .WithMany("VisitorReviewDetail")
                        .HasForeignKey("VisitorReviewCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("VisitorReviewNavigation");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.City", b =>
                {
                    b.Navigation("ParkNavigation");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.Governate", b =>
                {
                    b.Navigation("CitiesNavigation");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.Region", b =>
                {
                    b.Navigation("GovernateNavigation");
                });

            modelBuilder.Entity("VisitorsSurvey.DLL.Entities.VisitorReview", b =>
                {
                    b.Navigation("VisitorReviewDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
