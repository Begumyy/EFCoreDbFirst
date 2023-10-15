using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceteSB.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    TCKN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    PINKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilaclar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullanimSekilleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullanimSekilleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    ReceteTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EreceteNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "ReceteIlaclari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlacId = table.Column<int>(type: "int", nullable: false),
                    ReceteId = table.Column<int>(type: "int", nullable: false),
                    KullanimSekliId = table.Column<int>(type: "int", nullable: false),
                    Periyot = table.Column<int>(type: "int", nullable: false),
                    Doz = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceteIlaclari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceteIlaclari_Ilaclar_IlacId",
                        column: x => x.IlacId,
                        principalTable: "Ilaclar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceteIlaclari_KullanimSekilleri_KullanimSekliId",
                        column: x => x.KullanimSekliId,
                        principalTable: "KullanimSekilleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceteIlaclari_Receteler_ReceteId",
                        column: x => x.ReceteId,
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
                name: "IX_ReceteIlaclari_IlacId",
                table: "ReceteIlaclari",
                column: "IlacId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceteIlaclari_KullanimSekliId",
                table: "ReceteIlaclari",
                column: "KullanimSekliId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceteIlaclari_ReceteId",
                table: "ReceteIlaclari",
                column: "ReceteId");

            migrationBuilder.CreateIndex(
                name: "IX_Receteler_DoktorId",
                table: "Receteler",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceteTani_TanilarId",
                table: "ReceteTani",
                column: "TanilarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceteIlaclari");

            migrationBuilder.DropTable(
                name: "ReceteTani");

            migrationBuilder.DropTable(
                name: "Ilaclar");

            migrationBuilder.DropTable(
                name: "KullanimSekilleri");

            migrationBuilder.DropTable(
                name: "Receteler");

            migrationBuilder.DropTable(
                name: "Tanilar");

            migrationBuilder.DropTable(
                name: "Doktorlar");
        }
    }
}
