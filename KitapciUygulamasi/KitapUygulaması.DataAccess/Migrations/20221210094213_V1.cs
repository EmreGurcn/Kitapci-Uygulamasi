using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitapUygulaması.DataAccess.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kargolar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KargoAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kargolar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SayfaSayisi = table.Column<int>(type: "int", nullable: false),
                    BasimYili = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "YayinEvleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayinEviAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YetkiliKisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YayinEvleri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KitapKategori",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapKategori", x => new { x.KitapID, x.KategoriID });
                    table.ForeignKey(
                        name: "FK_KitapKategori_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapKategori_Kitaplar_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MusteriID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KargoID = table.Column<int>(type: "int", nullable: false),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Siparisler_Kargolar_KargoID",
                        column: x => x.KargoID,
                        principalTable: "Kargolar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siparisler_Musteriler_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilçe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YayinEviID = table.Column<int>(type: "int", nullable: false),
                    KargoID = table.Column<int>(type: "int", nullable: false),
                    MusteriID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Adresler_Kargolar_KargoID",
                        column: x => x.KargoID,
                        principalTable: "Kargolar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adresler_Musteriler_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adresler_YayinEvleri_YayinEviID",
                        column: x => x.YayinEviID,
                        principalTable: "YayinEvleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapYayinEvi",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false),
                    YayinEviID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYayinEvi", x => new { x.KitapID, x.YayinEviID });
                    table.ForeignKey(
                        name: "FK_KitapYayinEvi_Kitaplar_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYayinEvi_YayinEvleri_YayinEviID",
                        column: x => x.YayinEviID,
                        principalTable: "YayinEvleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefonlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelefonNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YayinEviID = table.Column<int>(type: "int", nullable: false),
                    KargoID = table.Column<int>(type: "int", nullable: false),
                    MusteriID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonlar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Telefonlar_Kargolar_KargoID",
                        column: x => x.KargoID,
                        principalTable: "Kargolar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_Musteriler_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_YayinEvleri_YayinEviID",
                        column: x => x.YayinEviID,
                        principalTable: "YayinEvleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapYazar",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false),
                    YazarID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazar", x => new { x.KitapID, x.YazarID });
                    table.ForeignKey(
                        name: "FK_KitapYazar_Kitaplar_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYazar_Yazarlar_YazarID",
                        column: x => x.YazarID,
                        principalTable: "Yazarlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiparisDetayi",
                columns: table => new
                {
                    SiparisID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KitapID = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<byte>(type: "tinyint", nullable: false),
                    IndirimOrani = table.Column<float>(type: "real", nullable: false),
                    SiparisTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisDetayi", x => new { x.SiparisID, x.KitapID });
                    table.ForeignKey(
                        name: "FK_SiparisDetayi_Kitaplar_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisDetayi_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_KargoID",
                table: "Adresler",
                column: "KargoID");

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_MusteriID",
                table: "Adresler",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_YayinEviID",
                table: "Adresler",
                column: "YayinEviID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapKategori_KategoriID",
                table: "KitapKategori",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYayinEvi_YayinEviID",
                table: "KitapYayinEvi",
                column: "YayinEviID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazar_YazarID",
                table: "KitapYazar",
                column: "YazarID");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetayi_KitapID",
                table: "SiparisDetayi",
                column: "KitapID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_KargoID",
                table: "Siparisler",
                column: "KargoID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_MusteriID",
                table: "Siparisler",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_KargoID",
                table: "Telefonlar",
                column: "KargoID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_MusteriID",
                table: "Telefonlar",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_YayinEviID",
                table: "Telefonlar",
                column: "YayinEviID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropTable(
                name: "KitapKategori");

            migrationBuilder.DropTable(
                name: "KitapYayinEvi");

            migrationBuilder.DropTable(
                name: "KitapYazar");

            migrationBuilder.DropTable(
                name: "SiparisDetayi");

            migrationBuilder.DropTable(
                name: "Telefonlar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Yazarlar");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "YayinEvleri");

            migrationBuilder.DropTable(
                name: "Kargolar");

            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
