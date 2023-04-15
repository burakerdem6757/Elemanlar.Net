using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolumlers",
                columns: table => new
                {
                    BolumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumIsmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumlers", x => x.BolumId);
                });

            migrationBuilder.CreateTable(
                name: "CalismaSeklis",
                columns: table => new
                {
                    CalismaSekliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalismaSekliIsmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalismaSeklis", x => x.CalismaSekliId);
                });

            migrationBuilder.CreateTable(
                name: "EgitimSeviyesis",
                columns: table => new
                {
                    EgitimSeviyesiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EgitimSeviyesiIsmi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitimSeviyesis", x => x.EgitimSeviyesiId);
                });

            migrationBuilder.CreateTable(
                name: "Firmalars",
                columns: table => new
                {
                    FirmaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaIsmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalars", x => x.FirmaId);
                });

            migrationBuilder.CreateTable(
                name: "HesapTurus",
                columns: table => new
                {
                    HesapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HesapTuruIsmi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HesapTurus", x => x.HesapId);
                });

            migrationBuilder.CreateTable(
                name: "IlanTurus",
                columns: table => new
                {
                    IlanTuruId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanTuruIsim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlanTurus", x => x.IlanTuruId);
                });

            migrationBuilder.CreateTable(
                name: "IsIlanlaris",
                columns: table => new
                {
                    IlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanIsmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlanIcerigi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IlanImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlanTuru = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PozisyonId = table.Column<int>(type: "int", nullable: false),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsIlanlaris", x => x.IlanId);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcılars",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoğumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonNumarasi = table.Column<int>(type: "int", nullable: false),
                    KullaniciFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HesapTuru = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    HesapOlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılars", x => x.KullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "Ozgecmiss",
                columns: table => new
                {
                    OzgecmisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonNumarası = table.Column<int>(type: "int", nullable: false),
                    AskerlikDurumu = table.Column<int>(type: "int", nullable: false),
                    SurucuBelgesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimSeviyesi = table.Column<int>(type: "int", nullable: false),
                    UniversiteBolumu = table.Column<int>(type: "int", nullable: false),
                    Universite = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ozgecmiss", x => x.OzgecmisId);
                });

            migrationBuilder.CreateTable(
                name: "Pozisyonlars",
                columns: table => new
                {
                    PozisyonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PozisyonIsmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pozisyonlars", x => x.PozisyonId);
                });

            migrationBuilder.CreateTable(
                name: "Sehirlers",
                columns: table => new
                {
                    SehirId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirIsmi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirlers", x => x.SehirId);
                });

            migrationBuilder.CreateTable(
                name: "UniversiteBolumus",
                columns: table => new
                {
                    UniversitBolumuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversiteBolumuIsmi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversiteBolumus", x => x.UniversitBolumuId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bolumlers");

            migrationBuilder.DropTable(
                name: "CalismaSeklis");

            migrationBuilder.DropTable(
                name: "EgitimSeviyesis");

            migrationBuilder.DropTable(
                name: "Firmalars");

            migrationBuilder.DropTable(
                name: "HesapTurus");

            migrationBuilder.DropTable(
                name: "IlanTurus");

            migrationBuilder.DropTable(
                name: "IsIlanlaris");

            migrationBuilder.DropTable(
                name: "Kullanıcılars");

            migrationBuilder.DropTable(
                name: "Ozgecmiss");

            migrationBuilder.DropTable(
                name: "Pozisyonlars");

            migrationBuilder.DropTable(
                name: "Sehirlers");

            migrationBuilder.DropTable(
                name: "UniversiteBolumus");
        }
    }
}
