﻿// <auto-generated />
using System;
using KitapUygulaması.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KitapUygulaması.DataAccess.Migrations
{
    [DbContext(typeof(KitapUygulamasiContext))]
    [Migration("20221212205341_V6")]
    partial class V6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Kargo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KargoAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Kargolar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.KargoAdres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AdresDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ilçe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KargoID")
                        .HasColumnType("int");

                    b.Property<string>("Mahalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostaKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KargoID");

                    b.ToTable("KargoAdresler");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Kategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Kitap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("BasimYili")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SayfaSayisi")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.KitapKategori", b =>
                {
                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 53, 40, 898, DateTimeKind.Local).AddTicks(8804));

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("KitapID", "KategoriID");

                    b.HasIndex("KategoriID");

                    b.ToTable("KitapKategori");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.KitapYayinEvi", b =>
                {
                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<int>("YayinEviID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 53, 40, 899, DateTimeKind.Local).AddTicks(995));

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("KitapID", "YayinEviID");

                    b.HasIndex("YayinEviID");

                    b.ToTable("KitapYayinEvi");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.KitapYazar", b =>
                {
                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 53, 40, 899, DateTimeKind.Local).AddTicks(3023));

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("KitapID", "YazarID");

                    b.HasIndex("YazarID");

                    b.ToTable("KitapYazar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Musteri", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.MusteriAdres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AdresDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ilçe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mahalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MusteriID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostaKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MusteriID");

                    b.ToTable("MusteriAdresler");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Siparis", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("KargoID")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MusteriID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SiparisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TeslimTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("KargoID");

                    b.HasIndex("MusteriID");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.SiparisDetayi", b =>
                {
                    b.Property<Guid>("SiparisID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<byte>("Adet")
                        .HasColumnType("tinyint");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 53, 40, 899, DateTimeKind.Local).AddTicks(6528));

                    b.Property<float>("IndirimOrani")
                        .HasColumnType("real");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("SiparisTutari")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SiparisID", "KitapID");

                    b.HasIndex("KitapID");

                    b.ToTable("SiparisDetayi");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Telefon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("KargoID")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MusteriID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YayinEviID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KargoID");

                    b.HasIndex("MusteriID");

                    b.HasIndex("YayinEviID");

                    b.ToTable("Telefonlar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.YayinEvi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("YayinEviAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YetkiliKisi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("YayinEvleri");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.YayinEviAdres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AdresDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ilçe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mahalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostaKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YayinEviID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("YayinEviID");

                    b.ToTable("YayinEviAdresler");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Yazar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("YazarAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.KargoAdres", b =>
                {
                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Kargo", "Kargo")
                        .WithMany("KargoAdresler")
                        .HasForeignKey("KargoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kargo");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.KitapKategori", b =>
                {
                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Kategori", "Kategori")
                        .WithMany("Kitaplar")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Kitap", "Kitap")
                        .WithMany("Kategoriler")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Kitap");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.KitapYayinEvi", b =>
                {
                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Kitap", "Kitap")
                        .WithMany("YayinEvileri")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitaciUygulamasi.Entities.Concrete.YayinEvi", "YayinEvi")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YayinEviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("YayinEvi");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.KitapYazar", b =>
                {
                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Kitap", "Kitap")
                        .WithMany("Yazarlar")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Yazar", "Yazar")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.MusteriAdres", b =>
                {
                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Musteri", "Musteri")
                        .WithMany("MusteriAdresleri")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Siparis", b =>
                {
                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Kargo", "Kargo")
                        .WithMany("Siparisler")
                        .HasForeignKey("KargoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Musteri", "Musteri")
                        .WithMany("Sipariler")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kargo");

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.SiparisDetayi", b =>
                {
                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Kitap", "Kitap")
                        .WithMany("Siparisler")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Siparis", "Siparis")
                        .WithMany("Kitaplar")
                        .HasForeignKey("SiparisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Telefon", b =>
                {
                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Kargo", "Kargo")
                        .WithMany("Telefonlar")
                        .HasForeignKey("KargoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitaciUygulamasi.Entities.Concrete.Musteri", "Musteri")
                        .WithMany("Telefonlar")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitaciUygulamasi.Entities.Concrete.YayinEvi", "YayinEvi")
                        .WithMany("Telefonlar")
                        .HasForeignKey("YayinEviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kargo");

                    b.Navigation("Musteri");

                    b.Navigation("YayinEvi");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.YayinEviAdres", b =>
                {
                    b.HasOne("KitaciUygulamasi.Entities.Concrete.YayinEvi", "YayinEvi")
                        .WithMany("Adresler")
                        .HasForeignKey("YayinEviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YayinEvi");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Kargo", b =>
                {
                    b.Navigation("KargoAdresler");

                    b.Navigation("Siparisler");

                    b.Navigation("Telefonlar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Kategori", b =>
                {
                    b.Navigation("Kitaplar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Kitap", b =>
                {
                    b.Navigation("Kategoriler");

                    b.Navigation("Siparisler");

                    b.Navigation("YayinEvileri");

                    b.Navigation("Yazarlar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Musteri", b =>
                {
                    b.Navigation("MusteriAdresleri");

                    b.Navigation("Sipariler");

                    b.Navigation("Telefonlar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Siparis", b =>
                {
                    b.Navigation("Kitaplar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.YayinEvi", b =>
                {
                    b.Navigation("Adresler");

                    b.Navigation("Kitaplar");

                    b.Navigation("Telefonlar");
                });

            modelBuilder.Entity("KitaciUygulamasi.Entities.Concrete.Yazar", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
