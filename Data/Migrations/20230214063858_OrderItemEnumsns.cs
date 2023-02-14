using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeansBurgersv2.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderItemEnumsns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Toppings",
                table: "OrderItems",
                newName: "Topping");

            migrationBuilder.RenameColumn(
                name: "Sauces",
                table: "OrderItems",
                newName: "Sauce");

            migrationBuilder.RenameColumn(
                name: "Patties",
                table: "OrderItems",
                newName: "Pattie");

            migrationBuilder.RenameColumn(
                name: "Buns",
                table: "OrderItems",
                newName: "Cheese");

            migrationBuilder.AddColumn<int>(
                name: "Bun",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bun",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "Topping",
                table: "OrderItems",
                newName: "Toppings");

            migrationBuilder.RenameColumn(
                name: "Sauce",
                table: "OrderItems",
                newName: "Sauces");

            migrationBuilder.RenameColumn(
                name: "Pattie",
                table: "OrderItems",
                newName: "Patties");

            migrationBuilder.RenameColumn(
                name: "Cheese",
                table: "OrderItems",
                newName: "Buns");
        }
    }
}
