using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitorsSurvey.DLL.Migrations
{
    /// <inheritdoc />
    public partial class Details : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT Park ON;");

            migrationBuilder.Sql(@"
                INSERT INTO Park (ParkCode, Name, ArabicName, CityCode) VALUES
                  (1, 'Central Park', N'الحديقة المركزية', 1),
                  (2, 'Green Valley Park', N'حديقة الوادي الأخضر', 2),
                  (3, 'Sunset Park', N'حديقة الغروب', 3),
                  (4, 'Oceanview Park', N'حديقة منظر البحر', 4);
           "); migrationBuilder.Sql("SET IDENTITY_INSERT Park OFF;");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
             DELETE FROM Park WHERE ParkCode IN (1, 2, 3, 4);
          ");

        }
    }
}
