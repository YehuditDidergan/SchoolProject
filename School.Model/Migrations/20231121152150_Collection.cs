using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Model.Migrations
{
    /// <inheritdoc />
    public partial class Collection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EMail",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EMail",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Teacher");
        }
    }
}
