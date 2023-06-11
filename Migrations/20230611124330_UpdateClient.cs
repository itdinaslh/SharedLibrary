using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SharedLibrary.Migrations
{
    public partial class UpdateClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    IsVerified = table.Column<bool>(type: "boolean", nullable: false),
                    IsB2B = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "TipeKendaraan",
                columns: table => new
                {
                    TipeKendaraanID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kode = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    NamaTipe = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipeKendaraan", x => x.TipeKendaraanID);
                });

            migrationBuilder.CreateTable(
                name: "ClientPkm",
                columns: table => new
                {
                    ClientPkmID = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientID = table.Column<Guid>(type: "uuid", nullable: false),
                    UserEmail = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Telp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Fax = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    KelurahanID = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Alamat = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Latitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Longitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    PenanggungJawab = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    NIK = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false),
                    NPWP = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    DokumenKTP = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DokumenNPWP = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    IsAngkut = table.Column<bool>(type: "boolean", nullable: false),
                    IsOlah = table.Column<bool>(type: "boolean", nullable: false),
                    IsUsaha = table.Column<bool>(type: "boolean", nullable: false),
                    NIB = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    DokumenNIB = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPkm", x => x.ClientPkmID);
                    table.ForeignKey(
                        name: "FK_ClientPkm_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientPkm_Kelurahan_KelurahanID",
                        column: x => x.KelurahanID,
                        principalTable: "Kelurahan",
                        principalColumn: "KelurahanID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientPkm_ClientID",
                table: "ClientPkm",
                column: "ClientID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientPkm_KelurahanID",
                table: "ClientPkm",
                column: "KelurahanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientPkm");

            migrationBuilder.DropTable(
                name: "TipeKendaraan");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
