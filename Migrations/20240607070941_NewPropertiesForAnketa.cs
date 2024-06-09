using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoTaxiAPI.Migrations
{
    /// <inheritdoc />
    public partial class NewPropertiesForAnketa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "can_start_work_date",
                table: "Anketas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "expected_salary",
                table: "Anketas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "can_start_work_date",
                table: "Anketas");

            migrationBuilder.DropColumn(
                name: "expected_salary",
                table: "Anketas");
        }
    }
}
