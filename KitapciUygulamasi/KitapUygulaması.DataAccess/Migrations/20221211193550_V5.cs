using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitapUygulaması.DataAccess.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YayinEviAdresler_Musteriler_MusteriID",
                table: "YayinEviAdresler");

            migrationBuilder.DropIndex(
                name: "IX_YayinEviAdresler_MusteriID",
                table: "YayinEviAdresler");

            migrationBuilder.DropColumn(
                name: "MusteriID",
                table: "YayinEviAdresler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MusteriID",
                table: "YayinEviAdresler",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_YayinEviAdresler_MusteriID",
                table: "YayinEviAdresler",
                column: "MusteriID");

            migrationBuilder.AddForeignKey(
                name: "FK_YayinEviAdresler_Musteriler_MusteriID",
                table: "YayinEviAdresler",
                column: "MusteriID",
                principalTable: "Musteriler",
                principalColumn: "ID");
        }
    }
}
