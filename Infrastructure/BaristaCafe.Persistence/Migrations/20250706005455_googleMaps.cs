using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaristaCafe.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class googleMaps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MapsUrl",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MapsUrl",
                table: "Locations");
        }
    }
}
