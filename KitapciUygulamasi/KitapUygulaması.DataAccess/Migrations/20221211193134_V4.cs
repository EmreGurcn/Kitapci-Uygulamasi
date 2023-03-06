using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitapUygulaması.DataAccess.Migrations
{
    public partial class V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresler_Musteriler_MusteriID",
                table: "Adresler");

            migrationBuilder.DropForeignKey(
                name: "FK_Adresler_YayinEvleri_YayinEviID",
                table: "Adresler");

            migrationBuilder.DropForeignKey(
                name: "FK_KargoAdres_Kargolar_KargoID",
                table: "KargoAdres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KargoAdres",
                table: "KargoAdres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adresler",
                table: "Adresler");

            migrationBuilder.RenameTable(
                name: "KargoAdres",
                newName: "KargoAdresler");

            migrationBuilder.RenameTable(
                name: "Adresler",
                newName: "YayinEviAdresler");

            migrationBuilder.RenameIndex(
                name: "IX_KargoAdres_KargoID",
                table: "KargoAdresler",
                newName: "IX_KargoAdresler_KargoID");

            migrationBuilder.RenameIndex(
                name: "IX_Adresler_YayinEviID",
                table: "YayinEviAdresler",
                newName: "IX_YayinEviAdresler_YayinEviID");

            migrationBuilder.RenameIndex(
                name: "IX_Adresler_MusteriID",
                table: "YayinEviAdresler",
                newName: "IX_YayinEviAdresler_MusteriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KargoAdresler",
                table: "KargoAdresler",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_YayinEviAdresler",
                table: "YayinEviAdresler",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "MusteriAdresler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilçe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriAdresler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MusteriAdresler_Musteriler_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusteriAdresler_MusteriID",
                table: "MusteriAdresler",
                column: "MusteriID");

            migrationBuilder.AddForeignKey(
                name: "FK_KargoAdresler_Kargolar_KargoID",
                table: "KargoAdresler",
                column: "KargoID",
                principalTable: "Kargolar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_YayinEviAdresler_Musteriler_MusteriID",
                table: "YayinEviAdresler",
                column: "MusteriID",
                principalTable: "Musteriler",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_YayinEviAdresler_YayinEvleri_YayinEviID",
                table: "YayinEviAdresler",
                column: "YayinEviID",
                principalTable: "YayinEvleri",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KargoAdresler_Kargolar_KargoID",
                table: "KargoAdresler");

            migrationBuilder.DropForeignKey(
                name: "FK_YayinEviAdresler_Musteriler_MusteriID",
                table: "YayinEviAdresler");

            migrationBuilder.DropForeignKey(
                name: "FK_YayinEviAdresler_YayinEvleri_YayinEviID",
                table: "YayinEviAdresler");

            migrationBuilder.DropTable(
                name: "MusteriAdresler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_YayinEviAdresler",
                table: "YayinEviAdresler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KargoAdresler",
                table: "KargoAdresler");

            migrationBuilder.RenameTable(
                name: "YayinEviAdresler",
                newName: "Adresler");

            migrationBuilder.RenameTable(
                name: "KargoAdresler",
                newName: "KargoAdres");

            migrationBuilder.RenameIndex(
                name: "IX_YayinEviAdresler_YayinEviID",
                table: "Adresler",
                newName: "IX_Adresler_YayinEviID");

            migrationBuilder.RenameIndex(
                name: "IX_YayinEviAdresler_MusteriID",
                table: "Adresler",
                newName: "IX_Adresler_MusteriID");

            migrationBuilder.RenameIndex(
                name: "IX_KargoAdresler_KargoID",
                table: "KargoAdres",
                newName: "IX_KargoAdres_KargoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adresler",
                table: "Adresler",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KargoAdres",
                table: "KargoAdres",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresler_Musteriler_MusteriID",
                table: "Adresler",
                column: "MusteriID",
                principalTable: "Musteriler",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresler_YayinEvleri_YayinEviID",
                table: "Adresler",
                column: "YayinEviID",
                principalTable: "YayinEvleri",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KargoAdres_Kargolar_KargoID",
                table: "KargoAdres",
                column: "KargoID",
                principalTable: "Kargolar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
