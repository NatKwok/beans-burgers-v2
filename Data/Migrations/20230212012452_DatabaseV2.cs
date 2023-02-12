using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeansBurgersv2.Data.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PriceId",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceId",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "PriceId",
                value: "price_1MaPG8BCj4yzLlBM6oasFbvw");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "PriceId",
                value: "price_1MaPGzBCj4yzLlBM3KjO1Kpx");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "PriceId",
                value: "price_1MaPIJBCj4yzLlBM4t7YOJia");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "PriceId",
                value: "price_1MaU5XBCj4yzLlBMcwJjmimD");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "PriceId",
                value: "price_1MaU4cBCj4yzLlBMQDfT35em");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "PriceId",
                value: "price_1MaPNTBCj4yzLlBMszenSdXm");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "PriceId",
                value: "price_1MaPO5BCj4yzLlBMebcKoU5G");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "PriceId",
                value: "price_1MaPOyBCj4yzLlBMVwvLdnCk");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "PriceId",
                value: "price_1MaPPWBCj4yzLlBMjq9gmgCF");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "PriceId",
                value: "price_1MaPQ8BCj4yzLlBMqjv0IOde");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                column: "PriceId",
                value: "price_1MaPQZBCj4yzLlBMQryc3PAO");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                column: "PriceId",
                value: "price_1MaPQvBCj4yzLlBMIGPZJ18h");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                column: "PriceId",
                value: "price_1MaPT6BCj4yzLlBMtZxovoxA");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                column: "PriceId",
                value: "price_1MaPTVBCj4yzLlBM9gieukCY");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                column: "PriceId",
                value: "price_1MaPTwBCj4yzLlBMUSUJ5e6b");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                column: "PriceId",
                value: "price_1MaPUHBCj4yzLlBMadRPMN5j");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                column: "PriceId",
                value: "price_1MaPUbBCj4yzLlBMhGwIkB2G");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                column: "PriceId",
                value: "price_1MaU0PBCj4yzLlBMRsjQlDe7");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                column: "PriceId",
                value: "price_1MaPUwBCj4yzLlBMH47I4iSy");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                column: "PriceId",
                value: "price_1MaPVkBCj4yzLlBM02MDuAD1");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                column: "PriceId",
                value: "price_1MaPW6BCj4yzLlBMlPVM9Nif");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                column: "PriceId",
                value: "price_1MaPWVBCj4yzLlBMb7aylAzK");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                column: "PriceId",
                value: "price_1MaPWrBCj4yzLlBM5dcYdjJK");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                column: "PriceId",
                value: "price_1MaPX9BCj4yzLlBMxmKZ8wIf");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                column: "PriceId",
                value: "price_1MaPXZBCj4yzLlBMPtVcmtUS");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                column: "PriceId",
                value: "price_1MaTy7BCj4yzLlBMMeRYOKUE");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                column: "PriceId",
                value: "price_1MaPk2BCj4yzLlBMAyFjfQOb");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                column: "PriceId",
                value: "price_1MaPmPBCj4yzLlBMlcYjC89X");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                column: "PriceId",
                value: "price_1MaPmfBCj4yzLlBM1jttErHA");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                column: "PriceId",
                value: "price_1MaTvOBCj4yzLlBMOXvxjLzA");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                column: "PriceId",
                value: "price_1MaPmyBCj4yzLlBMrJ0oyeA3");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                column: "PriceId",
                value: "price_1MaPnQBCj4yzLlBMVzBDmzJj");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "PriceId",
                value: "price_1MaPnsBCj4yzLlBMfQCsVJ8X");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "PriceId",
                value: "price_1MaPo7BCj4yzLlBMycWmVeF8");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "PriceId",
                value: "price_1MaPoSBCj4yzLlBMKNvdC857");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "PriceId",
                value: "price_1MaPonBCj4yzLlBMzSJeAZ62");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "PriceId",
                value: "price_1MaPp6BCj4yzLlBMKCSQRMmJ");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "PriceId",
                value: "price_1MaPpSBCj4yzLlBMEm25nirQ");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "PriceId",
                value: "price_1MaPphBCj4yzLlBMrDEHrEhL");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "PriceId",
                value: "price_1MaPq3BCj4yzLlBMnX2HqA1t");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "PriceId",
                value: "price_1MaPqIBCj4yzLlBMawfkvOz9");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "PriceId",
                value: "price_1MaPqhBCj4yzLlBM2XCTsEuI");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "PriceId",
                value: "price_1MaPqzBCj4yzLlBMFOXHgZ8Y");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "PriceId",
                value: "price_1MaPrFBCj4yzLlBMArtP1kyt");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "PriceId",
                value: "price_1MaPraBCj4yzLlBM8bXl4M1q");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "PriceId",
                value: "price_1MaPrvBCj4yzLlBMIXo4gjjh");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "PriceId",
                value: "price_1MaPsEBCj4yzLlBMpqrhKWIc");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "PriceId",
                value: "price_1MaPstBCj4yzLlBM2znngda6");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "PriceId",
                value: "price_1MaPtLBCj4yzLlBM1hgrbgkg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "PriceId",
                value: "price_1MaPtqBCj4yzLlBMJx1PeQ7I");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "PriceId",
                value: "price_1MaPvIBCj4yzLlBMUP2Hok64");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "PriceId",
                value: "price_1MaPviBCj4yzLlBMkqVdH1BL");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "PriceId",
                value: "price_1MaPwFBCj4yzLlBMh5323pJ9");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "Ingredients");
        }
    }
}
