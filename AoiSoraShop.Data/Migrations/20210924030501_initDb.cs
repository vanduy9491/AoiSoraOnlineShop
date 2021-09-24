using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AoiSoraShop.Data.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 24, 10, 5, 0, 674, DateTimeKind.Local).AddTicks(505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 24, 9, 29, 52, 190, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page of AoiSoraShop" },
                    { "HomeKeyword", "This is keyword of AoiSoraShop" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "IsShowOnHome", "ParentId", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, "Áo nam", true, null, "ao-nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam", 1, 1 },
                    { 2, "Áo nữ", true, null, "ao-nu", "Sản phẩm áo thời trang nữ", "Sản phẩm áo thời trang nữ", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "Description", "Details", "IsFeatured", "OriginalPrice", "Price", "ProductName", "SeoAlias", "SeoDecription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 24, 10, 5, 0, 682, DateTimeKind.Local).AddTicks(5258), "Áo sơ mi trắng", "Áo sơ mi trắng", null, 1000000m, 200000m, "Áo sơ mi trắng", "ao-so-mi-trang", "Áo sơ mi trắng", "Áo sơ mi trắng" },
                    { 2, new DateTime(2021, 9, 24, 10, 5, 0, 682, DateTimeKind.Local).AddTicks(7560), "Áo thun trắng", "Áo thun trắng", null, 1000000m, 200000m, "Áo thun trắng", "ao-thun-trang", "Áo thun trắng", "Áo thun trắng" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 24, 9, 29, 52, 190, DateTimeKind.Local).AddTicks(927),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 24, 10, 5, 0, 674, DateTimeKind.Local).AddTicks(505));
        }
    }
}
