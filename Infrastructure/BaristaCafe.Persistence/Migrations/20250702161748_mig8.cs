using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaristaCafe.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuName",
                table: "CafeMenus");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CafeMenus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MenuName",
                table: "CafeMenus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CafeMenus",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
