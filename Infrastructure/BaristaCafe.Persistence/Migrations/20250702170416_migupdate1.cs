using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaristaCafe.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migupdate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaristaDescs",
                columns: table => new
                {
                    BaristaDescId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BigTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaristaDescs", x => x.BaristaDescId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaristaDescs");
        }
    }
}
