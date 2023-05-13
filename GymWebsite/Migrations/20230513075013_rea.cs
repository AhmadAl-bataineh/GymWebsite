using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymWebsite.Migrations
{
    /// <inheritdoc />
    public partial class rea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "SportLists");

            migrationBuilder.DropColumn(
                name: "SportTitle",
                table: "SportLists");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Month",
                table: "SportLists",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SportTitle",
                table: "SportLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
