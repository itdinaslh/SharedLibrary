using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SharedLibrary.Migrations
{
    public partial class CraeteTimbanganTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPasar",
                table: "Kendaraan",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "TglUjiEmisi",
                table: "DokumenKendaraan",
                type: "date",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pemimbangan",
                columns: table => new
                {
                    TransactionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TransactionGUID = table.Column<Guid>(type: "uuid", nullable: false),
                    KendaraanID = table.Column<Guid>(type: "uuid", nullable: false),
                    NoPolisi = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    NoPintu = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    BeratMasuk = table.Column<int>(type: "integer", nullable: false),
                    TglMasuk = table.Column<DateOnly>(type: "date", nullable: false),
                    JamMasuk = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    InDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StatusID = table.Column<int>(type: "integer", nullable: true),
                    IsPasar = table.Column<bool>(type: "boolean", nullable: true),
                    RFID = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    BeratKeluar = table.Column<int>(type: "integer", nullable: true),
                    Penugasan = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: true),
                    AreaKerja = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    TglKeluar = table.Column<DateOnly>(type: "date", nullable: true),
                    JamKeluar = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    OutDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pemimbangan", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Pemimbangan_Kendaraan_KendaraanID",
                        column: x => x.KendaraanID,
                        principalTable: "Kendaraan",
                        principalColumn: "KendaraanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pemimbangan_Status_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pemimbangan_KendaraanID",
                table: "Pemimbangan",
                column: "KendaraanID");

            migrationBuilder.CreateIndex(
                name: "IX_Pemimbangan_StatusID",
                table: "Pemimbangan",
                column: "StatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pemimbangan");

            migrationBuilder.DropColumn(
                name: "IsPasar",
                table: "Kendaraan");

            migrationBuilder.DropColumn(
                name: "TglUjiEmisi",
                table: "DokumenKendaraan");
        }
    }
}
