using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeansBurgersv2.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Burgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burgers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Total = table.Column<decimal>(type: "money", nullable: false),
                    DeliveryCost = table.Column<decimal>(type: "money", nullable: false),
                    Tax = table.Column<decimal>(type: "money", nullable: false),
                    StripePaymentCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCard = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentInfos_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraCost = table.Column<double>(type: "float", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    BurgerId = table.Column<int>(type: "int", nullable: true),
                    MenuItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Burgers_BurgerId",
                        column: x => x.BurgerId,
                        principalTable: "Burgers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ingredients_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemId = table.Column<int>(type: "int", nullable: true),
                    CustomBurger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BurgerPrice = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "BurgerId", "Category", "ExtraCost", "MenuItemId", "Name", "PictureURL" },
                values: new object[,]
                {
                    { 1, null, 0, 3.5, null, "Brioche", null },
                    { 2, null, 0, 3.5, null, "Ciabatta", null },
                    { 3, null, 0, 3.75, null, "Whole Wheat Brioche", null },
                    { 4, null, 0, 3.75, null, "Sesame Seed Brioche", null },
                    { 5, null, 0, 3.75, null, "Poppy Seed Brioche", null },
                    { 6, null, 1, 7.0500001907348633, null, "Angus Beef", null },
                    { 7, null, 1, 6.5, null, "Fried Chicken", null },
                    { 8, null, 1, 6.0, null, "Fish Cake", null },
                    { 9, null, 1, 8.0, null, "Bison", null },
                    { 10, null, 1, 7.0, null, "Beyond Meat", null },
                    { 11, null, 1, 5.5, null, "Portobello", null },
                    { 12, null, 2, 3.25, null, "Lettuce", null },
                    { 13, null, 2, 3.25, null, "Tomatoes", null },
                    { 14, null, 2, 3.25, null, "Pickles", null },
                    { 15, null, 2, 3.25, null, "Red Onions", null },
                    { 16, null, 2, 3.5, null, "Caramelized Onions", null },
                    { 17, null, 2, 3.5, null, "Mushrooms", null },
                    { 18, null, 2, 3.5, null, "Banana Peppers", null },
                    { 19, null, 2, 4.0, null, "Cheddar Cheese", null },
                    { 20, null, 2, 7.0, null, "Bacon", null },
                    { 21, null, 2, 4.25, null, "Jalapeno Monterey Jack", null },
                    { 22, null, 2, 4.5, null, "Swiss Cheese", null },
                    { 23, null, 2, 4.25, null, "Goat Cheese", null },
                    { 24, null, 3, 3.0, null, "Ketchup", null },
                    { 25, null, 3, 3.0, null, "Mustard", null },
                    { 26, null, 3, 3.0, null, "Relish", null },
                    { 27, null, 3, 3.25, null, "Mayonnaise", null },
                    { 28, null, 3, 3.5, null, "Spicy Mayonnaise", null },
                    { 29, null, 3, 3.25, null, "Tartar Sauce", null },
                    { 30, null, 3, 3.25, null, "Barbecue Sauce", null },
                    { 31, null, 3, 3.5, null, "Pico de Gallo", null },
                    { 32, null, 3, 3.75, null, "Guacamole", null }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Fries", 5.5 },
                    { 2, "Poutine", 7.5 },
                    { 3, "Chicken Nuggets", 6.5 },
                    { 4, "Onion Rings", 6.0 },
                    { 5, "Fried Pickles", 5.5 },
                    { 6, "Cheese Sticks", 7.0 },
                    { 7, "Pepsi", 3.5 },
                    { 8, "7-Up", 3.5 },
                    { 9, "Iced Tea", 3.5 },
                    { 10, "Dom Perignon Brut Champagne", 214.97000122070312 },
                    { 11, "Celebrity Appearance", 999.989990234375 },
                    { 12, "24 Karat Gold Leaf", 15.0 },
                    { 13, "Glenfarclas Single Malt 25", 199.99000549316406 },
                    { 14, "Diner avec Jay-Z", 500000.0 },
                    { 15, "La Basique", 29.25 },
                    { 16, "Le Fumé", 31.989999771118164 },
                    { 17, "La Volaille", 24.5 },
                    { 18, "La Piscicole", 22.5 },
                    { 19, "Le Champignon", 31.25 },
                    { 20, "La Pastourelle", 35.75 },
                    { 21, "Le Mex", 31.75 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_BurgerId",
                table: "Ingredients",
                column: "BurgerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MenuItemId",
                table: "Ingredients",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_MenuItemId",
                table: "OrderItems",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInfos_CustomerId",
                table: "PaymentInfos",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "PaymentInfos");

            migrationBuilder.DropTable(
                name: "Burgers");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
