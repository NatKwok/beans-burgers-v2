using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeansBurgersv2.Data.Migrations
{
    /// <inheritdoc />
    public partial class SevenupImageLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/7up.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageName",
                value: "https://beansburgersblobs.blob.core.windows.net/beansburgers/7-Up.png");
        }
    }
}
