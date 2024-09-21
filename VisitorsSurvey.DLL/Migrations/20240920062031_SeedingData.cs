using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitorsSurvey.DLL.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT Region ON;");

            migrationBuilder.Sql(@"
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (1, 'Riyadh',N'الرياض');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (2, 'Makkah',N'مكة ');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (3, 'Madinah',N'المدينة ');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (4, 'Eastern Province',N'المنطقة الشرقية ');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (5, 'Qassim',N' القصيم ');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (6, 'Hail',N'حيل ');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (7, 'Tabuk',N'تبوك');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (8, 'Asir',N'عسير');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (9, 'Jazan',N'جيزان ');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (10, 'Najran',N'نجران ');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (11, 'Baha',N'بها');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (12, 'Northern Borders',N' المنطقة الشمالية ');
      INSERT INTO Region (RegionCode, Name , ArabicName) VALUES (13, 'Jouf',N'جوووف');
  ");
            migrationBuilder.Sql("SET IDENTITY_INSERT Region OFF;");
            migrationBuilder.Sql("SET IDENTITY_INSERT Governate ON;");

            // Insert governates into the Governates table using SQL
            migrationBuilder.Sql(@"
    INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (1, 'Al-Kharj', N'الخرج  ', 1);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (2, 'Al-Muzahimiyah', N'المزاحمية', 1);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (3, 'Jeddah', N'جدة', 2);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (4, 'Taif', N'الطائف', 2);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (5, 'Yanbu', N'ينبع', 3);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (6, 'Al-Khobar', N'الخبر', 4);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (7, 'Buraydah', N'بريدة', 5);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (8, 'Hail', N'حائل', 6);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (9, 'Tabuk', N'تبوك', 7);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (10, 'Abha', N'أبها', 8);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (11, 'Jazan', N'جازان', 9);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (12, 'Najran', N'نجران', 10);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (13, 'Al-Baha', N'الباحة', 11);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (14, 'Arar', N'عرعر', 12);
INSERT INTO Governate (GovernateCode, Name, ArabicName, RegionCode) VALUES (15, 'Sakakah', N'سكاكا', 13);

  ");
            migrationBuilder.Sql("SET IDENTITY_INSERT Governate OFF;");

            migrationBuilder.Sql("SET IDENTITY_INSERT City ON;");

            // Insert cities into the Cities table using SQL
            migrationBuilder.Sql(@"
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (1, N'مدينة الخرج', 'Al-Kharj City', 1);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (2, N'مدينة المزاحمية', 'Al-Muzahimiyah City', 2);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (3, N'مدينة جدة', 'Jeddah City', 3);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (4, N'مدينة الطائف', 'Taif City', 4);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (5, N'مدينة ينبع', 'Yanbu City', 5);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (6, N'مدينة الخبر', 'Al-Khobar City', 6);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (7, N'مدينة بريدة', 'Buraydah City', 7);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (8, N'مدينة حائل', 'Hail City', 8);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (9, N'مدينة تبوك', 'Tabuk City', 9);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (10, N'مدينة أبها', 'Abha City', 10);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (11, N'مدينة جازان', 'Jazan City', 11);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (12, N'مدينة نجران', 'Najran City', 12);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (13, N'مدينة الباحة', 'Al-Baha City', 13);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (14, N'مدينة عرعر', 'Arar City', 14);
INSERT INTO City(CityCode, ArabicName, Name, GovernateCode) VALUES (15, N'مدينة سكاكا', 'Sakakah City', 15);

  "); migrationBuilder.Sql("SET IDENTITY_INSERT City OFF;");


            migrationBuilder.Sql("SET IDENTITY_INSERT Weekday ON;");
            migrationBuilder.Sql("INSERT INTO Weekday (WeekDayCode,Name, ArabicName) VALUES (3,'Monday', N'الإثنين')");
            migrationBuilder.Sql("INSERT INTO Weekday (WeekDayCode,Name, ArabicName) VALUES (4,'Tuesday', N'الثلاثاء')");
            migrationBuilder.Sql("INSERT INTO Weekday (WeekDayCode,Name, ArabicName) VALUES (5,'Wednesday', N'الأربعاء')");
            migrationBuilder.Sql("INSERT INTO Weekday (WeekDayCode,Name, ArabicName) VALUES (6,'Thursday', N'الخميس')");
            migrationBuilder.Sql("INSERT INTO Weekday (WeekDayCode,Name, ArabicName) VALUES (7,'Friday', N'الجمعة')");
            migrationBuilder.Sql("INSERT INTO Weekday (WeekDayCode, Name, ArabicName) VALUES (1,'Saturday', N'السبت')");
            migrationBuilder.Sql("INSERT INTO Weekday (WeekDayCode,Name, ArabicName) VALUES (2,'Sunday', N'الأحد')");
            migrationBuilder.Sql("SET IDENTITY_INSERT Weekday OFF;");


            migrationBuilder.Sql("SET IDENTITY_INSERT YearMonth ON;");

            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('01', 'January', N'يناير')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('02', 'February', N'فبراير')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('03', 'March', N'مارس')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('04', 'April', N'أبريل')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('05', 'May', N'مايو')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('06', 'June', N'يونيو')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('07', 'July', N'يوليو')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('08', 'August', N'أغسطس')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('09', 'September', N'سبتمبر')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('10', 'October', N'أكتوبر')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('11', 'November', N'نوفمبر')");
            migrationBuilder.Sql("INSERT INTO YearMonth (YearMonthCode, Name, ArabicName) VALUES ('12', 'December', N'ديسمبر')");
            migrationBuilder.Sql("SET IDENTITY_INSERT YearMonth OFF;");

            migrationBuilder.Sql(@"
    
        INSERT INTO [dbo].[VisitorReviewItem] ([Name], [ArabicName])
        VALUES
        ('Service Area', N'منطقة الخدمات'),
        ('Gates', N'البوبات'),
        ('Children Area', N'منطقة الاطفال'),
        ('Roads and Pathways', N'الطرق والممرات'),
        ('Restaurants', N'المطاعم'),
        ('Shades', N'المظلات'),
        ('Parking', N'المواقف'),
        ('Guidance and Direction', N'التوجية والارشاد'),
        ('Directional Signage', N'اللافتات الارشادية'),
        ('Vegetation Cover', N'الغطاء النباتى');
    
");
            migrationBuilder.Sql("SET IDENTITY_INSERT Rate ON;");

            migrationBuilder.Sql(@"
    IF NOT EXISTS (SELECT 1 FROM [SurveyDb].[dbo].[Rate])
    BEGIN
        INSERT INTO [SurveyDb].[dbo].[Rate] ([RateCode], [Name], [ArabicName])
        VALUES
        (001,'very Satisfaied ', N'راضى جدا'),
        (002, 'Satisfaied', N'راضى'),
        (003, 'Neural', N'محايد'),
        (004, 'disSatisfaied', N'غير راضى '),
        (005, 'Very disSatisfaied', N'غير راضى جداً');
    END
");
            migrationBuilder.Sql("SET IDENTITY_INSERT Rate OFF;");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {


            // Remove the cities from the Cities table using SQL
            migrationBuilder.Sql(@"
      DELETE FROM City WHERE CityCode IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
  ");

            // Remove the governates from the Governates table using SQL
            migrationBuilder.Sql(@"
      DELETE FROM Governate WHERE GovernateCode IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
  ");

            // Remove the regions from the Regions table using SQL
            migrationBuilder.Sql(@"
      DELETE FROM Region WHERE RegionCode IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
  ");
            migrationBuilder.Sql("DELETE FROM Weekday WHERE WeekDayCode IN (1,2,3,4,5,6,7)");

            migrationBuilder.Sql("DELETE FROM YearMonth WHERE YearMonthCode BETWEEN '01' AND '12'");
            migrationBuilder.Sql(@"
    DELETE FROM [dbo].[VisitorReviewItem]
    WHERE [Name] IN ('Service Area', 'Gates', 'Children Area', 'Roads and Pathways', 'Restaurants', 'Shades', 'Parking', 'Guidance and Direction', 'Directional Signage', 'Vegetation Cover');
");
            migrationBuilder.Sql(@"
    DELETE FROM [SurveyDb].[dbo].[Rate]
    WHERE [RateCode] IN (001, 002, 003, 004, 005);
");

        }
    }
}
