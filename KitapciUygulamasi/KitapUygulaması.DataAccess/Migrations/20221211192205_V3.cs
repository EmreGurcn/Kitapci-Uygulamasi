using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitapUygulaması.DataAccess.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresler_Kargolar_KargoID",
                table: "Adresler");

            migrationBuilder.DropForeignKey(
                name: "FK_Adresler_Musteriler_MusteriID",
                table: "Adresler");

            migrationBuilder.DropIndex(
                name: "IX_Adresler_KargoID",
                table: "Adresler");

            migrationBuilder.DropColumn(
                name: "KargoID",
                table: "Adresler");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "SiparisDetayi",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "SiparisDetayi",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "KitapYazar",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "KitapYazar",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "KitapYayinEvi",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "KitapYayinEvi",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "KitapKategori",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "KitapKategori",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<Guid>(
                name: "MusteriID",
                table: "Adresler",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "KargoAdres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilçe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KargoID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoAdres", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KargoAdres_Kargolar_KargoID",
                        column: x => x.KargoID,
                        principalTable: "Kargolar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KargoAdres_KargoID",
                table: "KargoAdres",
                column: "KargoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresler_Musteriler_MusteriID",
                table: "Adresler",
                column: "MusteriID",
                principalTable: "Musteriler",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresler_Musteriler_MusteriID",
                table: "Adresler");

            migrationBuilder.DropTable(
                name: "KargoAdres");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "SiparisDetayi",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "SiparisDetayi",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "KitapYazar",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "KitapYazar",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "KitapYayinEvi",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "KitapYayinEvi",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "KitapKategori",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "KitapKategori",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MusteriID",
                table: "Adresler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KargoID",
                table: "Adresler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_KargoID",
                table: "Adresler",
                column: "KargoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresler_Kargolar_KargoID",
                table: "Adresler",
                column: "KargoID",
                principalTable: "Kargolar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresler_Musteriler_MusteriID",
                table: "Adresler",
                column: "MusteriID",
                principalTable: "Musteriler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
