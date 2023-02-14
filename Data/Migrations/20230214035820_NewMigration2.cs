using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeansBurgersv2.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrdersDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalItems = table.Column<int>(type: "int", nullable: false),
                    totalPrice = table.Column<double>(type: "float", nullable: false),
                    totalTax = table.Column<double>(type: "float", nullable: false),
                    grandTotal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderDetailsId",
                table: "OrderItems",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_OrdersDetails_OrderDetailsId",
                table: "OrderItems",
                column: "OrderDetailsId",
                principalTable: "OrdersDetails",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_OrdersDetails_OrderDetailsId",
                table: "OrderItems");

            migrationBuilder.DropTable(
                name: "OrdersDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderDetailsId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "OrderItems");

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Buns", "Description", "ImageName", "Name", "Patties", "Price", "Sauces", "Toppings" },
                values: new object[] { 22, 0, null, "https://beansburgersblobs.blob.core.windows.net/beansburgers/Fries.png", "Fries", 0, 5.5, 0, 0 });
        }
    }
}
