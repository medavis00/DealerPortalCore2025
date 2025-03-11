using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor.Scheduler.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InstructorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOffered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LengthInMinutes = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TotalNumberOfStudents = table.Column<int>(type: "int", nullable: false),
                    MaximumCapacity = table.Column<int>(type: "int", nullable: true),
                    TeamsMeetingLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ReplayLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false),
                    EnrollmentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog");
        }
    }
}
