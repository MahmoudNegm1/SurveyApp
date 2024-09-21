using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitorsSurvey.DLL.Migrations
{
    /// <inheritdoc />
    public partial class CreatingSomeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Rate",
                schema: "dbo",
                columns: table => new
                {
                    RateCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.RateCode);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                schema: "dbo",
                columns: table => new
                {
                    RegionCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionCode);
                });

            migrationBuilder.CreateTable(
                name: "VisitorReview",
                schema: "dbo",
                columns: table => new
                {
                    VisitorReviewCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeekDayName = table.Column<int>(type: "int", nullable: false),
                    DayOfMonth = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    RegionCode = table.Column<int>(type: "int", nullable: false),
                    GovernateCode = table.Column<int>(type: "int", nullable: false),
                    CityCode = table.Column<int>(type: "int", nullable: false),
                    ParkCode = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorReview", x => x.VisitorReviewCode);
                });

            migrationBuilder.CreateTable(
                name: "VisitorReviewItem",
                schema: "dbo",
                columns: table => new
                {
                    VisitorReviewItemCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorReviewItem", x => x.VisitorReviewItemCode);
                });

            migrationBuilder.CreateTable(
                name: "WeekDay",
                schema: "dbo",
                columns: table => new
                {
                    WeekDayCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDay", x => x.WeekDayCode);
                });

            migrationBuilder.CreateTable(
                name: "YearMonth",
                schema: "dbo",
                columns: table => new
                {
                    YearMonthCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearMonth", x => x.YearMonthCode);
                });

            migrationBuilder.CreateTable(
                name: "Governate",
                schema: "dbo",
                columns: table => new
                {
                    GovernateCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governate", x => x.GovernateCode);
                    table.ForeignKey(
                        name: "FK_Governate_Region_RegionCode",
                        column: x => x.RegionCode,
                        principalSchema: "dbo",
                        principalTable: "Region",
                        principalColumn: "RegionCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VisitorReviewDetail",
                schema: "dbo",
                columns: table => new
                {
                    VisitorReviewDetailCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorItemCode = table.Column<int>(type: "int", nullable: false),
                    RateCode = table.Column<int>(type: "int", nullable: false),
                    VisitorReviewCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorReviewDetail", x => x.VisitorReviewDetailCode);
                    table.ForeignKey(
                        name: "FK_VisitorReviewDetail_VisitorReview_VisitorReviewCode",
                        column: x => x.VisitorReviewCode,
                        principalSchema: "dbo",
                        principalTable: "VisitorReview",
                        principalColumn: "VisitorReviewCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "dbo",
                columns: table => new
                {
                    CityCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovernateCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityCode);
                    table.ForeignKey(
                        name: "FK_City_Governate_GovernateCode",
                        column: x => x.GovernateCode,
                        principalSchema: "dbo",
                        principalTable: "Governate",
                        principalColumn: "GovernateCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Park",
                schema: "dbo",
                columns: table => new
                {
                    ParkCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Park", x => x.ParkCode);
                    table.ForeignKey(
                        name: "FK_Park_City_CityCode",
                        column: x => x.CityCode,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "CityCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_GovernateCode",
                schema: "dbo",
                table: "City",
                column: "GovernateCode");

            migrationBuilder.CreateIndex(
                name: "IX_Governate_RegionCode",
                schema: "dbo",
                table: "Governate",
                column: "RegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Park_CityCode",
                schema: "dbo",
                table: "Park",
                column: "CityCode");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorReviewDetail_VisitorReviewCode",
                schema: "dbo",
                table: "VisitorReviewDetail",
                column: "VisitorReviewCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Park",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Rate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "VisitorReviewDetail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "VisitorReviewItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WeekDay",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "YearMonth",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "City",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "VisitorReview",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Governate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Region",
                schema: "dbo");
        }
    }
}
