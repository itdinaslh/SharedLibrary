using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharedLibrary.Migrations
{
    public partial class AddKendaraan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kendaraan",
                columns: table => new
                {
                    KendaraanID = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientID = table.Column<Guid>(type: "uuid", nullable: false),
                    AreaKerja = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    NoPolisi = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    NoPintu = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    TipeKendaraanID = table.Column<int>(type: "integer", nullable: false),
                    RFID = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    TahunPembuatan = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: true),
                    BeratKIR = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kendaraan", x => x.KendaraanID);
                    table.ForeignKey(
                        name: "FK_Kendaraan_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kendaraan_TipeKendaraan_TipeKendaraanID",
                        column: x => x.TipeKendaraanID,
                        principalTable: "TipeKendaraan",
                        principalColumn: "TipeKendaraanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DokumenKendaraan",
                columns: table => new
                {
                    DokumenKendaraanID = table.Column<Guid>(type: "uuid", nullable: false),
                    KendaraanID = table.Column<Guid>(type: "uuid", nullable: false),
                    TglSTNK = table.Column<DateOnly>(type: "date", nullable: false),
                    TglKIR = table.Column<DateOnly>(type: "date", nullable: false),
                    DokumenSTNK = table.Column<string>(type: "text", nullable: true),
                    DokumenKIR = table.Column<string>(type: "text", nullable: true),
                    FotoKendaraan = table.Column<string>(type: "text", nullable: true),
                    BuktiUjiEmisi = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DokumenKendaraan", x => x.DokumenKendaraanID);
                    table.ForeignKey(
                        name: "FK_DokumenKendaraan_Kendaraan_KendaraanID",
                        column: x => x.KendaraanID,
                        principalTable: "Kendaraan",
                        principalColumn: "KendaraanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DokumenKendaraan_KendaraanID",
                table: "DokumenKendaraan",
                column: "KendaraanID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_ClientID",
                table: "Kendaraan",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_TipeKendaraanID",
                table: "Kendaraan",
                column: "TipeKendaraanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DokumenKendaraan");

            migrationBuilder.DropTable(
                name: "Kendaraan");
        }
    }
}
