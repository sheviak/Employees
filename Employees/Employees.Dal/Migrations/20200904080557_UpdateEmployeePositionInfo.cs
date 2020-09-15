using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employees.Dal.Migrations
{
    public partial class UpdateEmployeePositionInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndedWork",
                table: "EmployeePositionInfos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndedWork",
                table: "EmployeePositionInfos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
