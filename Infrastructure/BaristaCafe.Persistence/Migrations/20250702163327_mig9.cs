using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaristaCafe.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu1s");

            migrationBuilder.DropTable(
                name: "Menu2s");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CafeMenus");

            migrationBuilder.DropColumn(
                name: "Favorite",
                table: "CafeMenus");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CafeMenus");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "CafeMenus",
                newName: "Title");

            migrationBuilder.AddColumn<int>(
                name: "CafeId",
                table: "CafeMenus",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    CafeMenuId = table.Column<int>(type: "int", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "CafeMenus",
                newName: "ProductName");

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

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CafeMenus",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Menu1s",
                columns: table => new
                {
                    Menu1Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu1s", x => x.Menu1Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu2s",
                columns: table => new
                {
                    Menu2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu2s", x => x.Menu2Id);
                });
        }
    }
}
