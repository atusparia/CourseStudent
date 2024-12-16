using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseStudent.Migrations
{
    /// <inheritdoc />
    public partial class V2agregarcamposaCourseyGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Grades",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Courses",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Courses");
        }
    }
}
