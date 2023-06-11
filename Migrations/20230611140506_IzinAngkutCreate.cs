using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SharedLibrary.Migrations
{
    public partial class IzinAngkutCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LokasiBuang",
                columns: table => new
                {
                    LokasiBuangID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaLokasi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LokasiBuang", x => x.LokasiBuangID);
                });

            migrationBuilder.CreateTable(
                name: "LokasiIzin",
                columns: table => new
                {
                    LokasiIzinID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaLokasi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LokasiIzin", x => x.LokasiIzinID);
                });

            migrationBuilder.CreateTable(
                name: "IzinAngkut",
                columns: table => new
                {
                    IzinAngkutID = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientID = table.Column<Guid>(type: "uuid", nullable: false),
                    UniqueID = table.Column<Guid>(type: "uuid", nullable: false),
                    JmlAngkutan = table.Column<int>(type: "integer", nullable: false),
                    NoIzinUsaha = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TglTerbitIzin = table.Column<DateOnly>(type: "date", nullable: false),
                    TglAkhirIzin = table.Column<DateOnly>(type: "date", nullable: false),
                    DokumenIzin = table.Column<string>(type: "text", nullable: true),
                    LokasiIzinID = table.Column<int>(type: "integer", nullable: false),
                    LokasiBuangID = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzinAngkut", x => x.IzinAngkutID);
                    table.ForeignKey(
                        name: "FK_IzinAngkut_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IzinAngkut_LokasiBuang_LokasiBuangID",
                        column: x => x.LokasiBuangID,
                        principalTable: "LokasiBuang",
                        principalColumn: "LokasiBuangID");
                    table.ForeignKey(
                        name: "FK_IzinAngkut_LokasiIzin_LokasiIzinID",
                        column: x => x.LokasiIzinID,
                        principalTable: "LokasiIzin",
                        principalColumn: "LokasiIzinID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IzinAngkutKendaraan",
                columns: table => new
                {
                    IzinAngkutsIzinAngkutID = table.Column<Guid>(type: "uuid", nullable: false),
                    KendaraansKendaraanID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzinAngkutKendaraan", x => new { x.IzinAngkutsIzinAngkutID, x.KendaraansKendaraanID });
                    table.ForeignKey(
                        name: "FK_IzinAngkutKendaraan_IzinAngkut_IzinAngkutsIzinAngkutID",
                        column: x => x.IzinAngkutsIzinAngkutID,
                        principalTable: "IzinAngkut",
                        principalColumn: "IzinAngkutID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IzinAngkutKendaraan_Kendaraan_KendaraansKendaraanID",
                        column: x => x.KendaraansKendaraanID,
                        principalTable: "Kendaraan",
                        principalColumn: "KendaraanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IzinAngkut_ClientID",
                table: "IzinAngkut",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_IzinAngkut_LokasiBuangID",
                table: "IzinAngkut",
                column: "LokasiBuangID");

            migrationBuilder.CreateIndex(
                name: "IX_IzinAngkut_LokasiIzinID",
                table: "IzinAngkut",
                column: "LokasiIzinID");

            migrationBuilder.CreateIndex(
                name: "IX_IzinAngkutKendaraan_KendaraansKendaraanID",
                table: "IzinAngkutKendaraan",
                column: "KendaraansKendaraanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IzinAngkutKendaraan");

            migrationBuilder.DropTable(
                name: "IzinAngkut");

            migrationBuilder.DropTable(
                name: "LokasiBuang");

            migrationBuilder.DropTable(
                name: "LokasiIzin");
        }
    }
}
