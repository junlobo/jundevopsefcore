using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JunDevOpsEFCore.Data.Migrations
{
    public partial class BuildDB_002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "CustomerID", "EmployeeID", "OrderDate" },
                values: new object[] { 1, 1, 1, new DateTime(2020, 5, 19, 14, 38, 56, 793, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailID", "OrderID", "ProductID", "Quantity" },
                values: new object[] { 1, 1, 1, 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1);
        }
    }
}
