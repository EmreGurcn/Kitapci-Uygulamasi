using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitapUygulaması.DataAccess.Migrations
{
    public partial class V6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SiparisDetayi",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 53, 40, 899, DateTimeKind.Local).AddTicks(6528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "KitapYazar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 53, 40, 899, DateTimeKind.Local).AddTicks(3023),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "KitapYayinEvi",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 53, 40, 899, DateTimeKind.Local).AddTicks(995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "KitapKategori",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 53, 40, 898, DateTimeKind.Local).AddTicks(8804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SiparisDetayi",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 53, 40, 899, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "KitapYazar",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 53, 40, 899, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "KitapYayinEvi",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 53, 40, 899, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "KitapKategori",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 53, 40, 898, DateTimeKind.Local).AddTicks(8804));
        }
    }
}
