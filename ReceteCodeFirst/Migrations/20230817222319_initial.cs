using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceteCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doktorlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brans = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DahiliNumara = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IlacAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoktorAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceteHazirlanisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktorlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilaclar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlacTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IlacAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoktorAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceteHazirlanisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilaclar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceteIlaclari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Periyot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doz = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    KullanimSekli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IlacAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoktorAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceteHazirlanisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceteIlaclari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TedavisiVarMi = table.Column<bool>(type: "bit", nullable: false),
                    TeshisKonulduMu = table.Column<bool>(type: "bit", nullable: false),
                    TestlerYapildiMi = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IlacAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoktorAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceteHazirlanisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receteler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tutar = table.Column<int>(type: "int", nullable: false),
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    ReceteIlaciId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IlacAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoktorAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceteHazirlanisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receteler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receteler_Doktorlar_DoktorId",
                        column: x => x.DoktorId,
                        principalTable: "Doktorlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receteler_ReceteIlaclari_ReceteIlaciId",
                        column: x => x.ReceteIlaciId,
                        principalTable: "ReceteIlaclari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IlacRecete",
                columns: table => new
                {
                    IlaclarId = table.Column<int>(type: "int", nullable: false),
                    RecetelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlacRecete", x => new { x.IlaclarId, x.RecetelerId });
                    table.ForeignKey(
                        name: "FK_IlacRecete_Ilaclar_IlaclarId",
                        column: x => x.IlaclarId,
                        principalTable: "Ilaclar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IlacRecete_Receteler_RecetelerId",
                        column: x => x.RecetelerId,
                        principalTable: "Receteler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceteTani",
                columns: table => new
                {
                    RecetelerId = table.Column<int>(type: "int", nullable: false),
                    TanilarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceteTani", x => new { x.RecetelerId, x.TanilarId });
                    table.ForeignKey(
                        name: "FK_ReceteTani_Receteler_RecetelerId",
                        column: x => x.RecetelerId,
                        principalTable: "Receteler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceteTani_Tanilar_TanilarId",
                        column: x => x.TanilarId,
                        principalTable: "Tanilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IlacRecete_RecetelerId",
                table: "IlacRecete",
                column: "RecetelerId");

            migrationBuilder.CreateIndex(
                name: "IX_Receteler_DoktorId",
                table: "Receteler",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Receteler_ReceteIlaciId",
                table: "Receteler",
                column: "ReceteIlaciId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceteTani_TanilarId",
                table: "ReceteTani",
                column: "TanilarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IlacRecete");

            migrationBuilder.DropTable(
                name: "ReceteTani");

            migrationBuilder.DropTable(
                name: "Ilaclar");

            migrationBuilder.DropTable(
                name: "Receteler");

            migrationBuilder.DropTable(
                name: "Tanilar");

            migrationBuilder.DropTable(
                name: "Doktorlar");

            migrationBuilder.DropTable(
                name: "ReceteIlaclari");
        }
    }
}
