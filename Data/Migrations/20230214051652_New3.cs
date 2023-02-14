using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeansBurgersv2.Data.Migrations
{
    /// <inheritdoc />
    public partial class New3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Buns",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Patties",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Sauces",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Toppings",
                table: "MenuItems");

            migrationBuilder.AddColumn<int>(
                name: "Buns",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Patties",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sauces",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Toppings",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Onion Rings.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Fried Pickles.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Cheese Sticks.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Pepsi.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/7-Up.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Iced Tea.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Dom Perignon Brut Champagne.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Arnold.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/24 Karat Gold Leaf.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Glenfarclas Single Malt 25.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Diner avec Jay-Z.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Cheese Sticks.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Le Fumé.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/La Volaille.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/La Piscicole.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Le Champignon.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/La Pastourelle.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/Le Mex.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Buns",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Patties",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Sauces",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Toppings",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "Buns",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Patties",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sauces",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Toppings",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Buns", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Buns", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Buns", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Buns", "ImageName", "Patties", "Sauces", "Toppings" },
                values: new object[] { 0, null, 0, 0, 0 });
        }
    }
}
