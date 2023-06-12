using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharedLibrary.Migrations
{
    public partial class AddLokasiAngkut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LokasiAngkut",
                columns: table => new
                {
                    LokasiAngkutID = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientID = table.Column<Guid>(type: "uuid", nullable: false),
                    KawasanID = table.Column<Guid>(type: "uuid", nullable: false),
                    UniqueID = table.Column<Guid>(type: "uuid", nullable: false),
                    NamaLokasi = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TglAwalKontrak = table.Column<DateOnly>(type: "date", nullable: false),
                    TglAkhirKontrak = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DokumenPath = table.Column<string>(type: "text", nullable: true),
                    IsApproved = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LokasiAngkut", x => x.LokasiAngkutID);
                    table.ForeignKey(
                        name: "FK_LokasiAngkut_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LokasiAngkut_Clients_KawasanID",
                        column: x => x.KawasanID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LokasiAngkut_ClientID",
                table: "LokasiAngkut",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_LokasiAngkut_KawasanID",
                table: "LokasiAngkut",
                column: "KawasanID");

            migrationBuilder.CreateIndex(
                name: "IX_LokasiAngkut_UniqueID",
                table: "LokasiAngkut",
                column: "UniqueID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LokasiAngkut");
        }
    }
}
