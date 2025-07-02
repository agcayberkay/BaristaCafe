using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaristaCafe.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class cleardatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CafeMenus_Cafes_CafeId",
                table: "CafeMenus");

            migrationBuilder.DropTable(
                name: "Cafes");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_CafeMenus_CafeId",
                table: "CafeMenus");

            migrationBuilder.DropColumn(
                name: "CafeId",
                table: "CafeMenus");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CafeMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Favorite",
                table: "CafeMenus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MenuName",
                table: "CafeMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CafeMenus",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "CafeMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Baristases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BigTitle",
                table: "Baristases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CafeMenus");

            migrationBuilder.DropColumn(
                name: "Favorite",
                table: "CafeMenus");

            migrationBuilder.DropColumn(
                name: "MenuName",
                table: "CafeMenus");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CafeMenus");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "CafeMenus");

            migrationBuilder.AddColumn<int>(
                name: "CafeId",
                table: "CafeMenus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Baristases",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BigTitle",
                table: "Baristases",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Cafes",
                columns: table => new
                {
                    CafeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cafes", x => x.CafeId);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CafeMenuId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItems_CafeMenus_CafeMenuId",
                        column: x => x.CafeMenuId,
                        principalTable: "CafeMenus",
                        principalColumn: "CafeMenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CafeMenus_CafeId",
                table: "CafeMenus",
                column: "CafeId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_CafeMenuId",
                table: "MenuItems",
                column: "CafeMenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_CafeMenus_Cafes_CafeId",
                table: "CafeMenus",
                column: "CafeId",
                principalTable: "Cafes",
                principalColumn: "CafeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
