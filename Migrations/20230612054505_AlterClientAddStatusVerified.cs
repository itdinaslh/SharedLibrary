using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharedLibrary.Migrations
{
    public partial class AlterClientAddStatusVerified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TahunPembuatan",
                table: "Kendaraan");

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Kendaraan",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "Kendaraan",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TahunPembuatan",
                table: "DokumenKendaraan",
                type: "character varying(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_StatusID",
                table: "Kendaraan",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kendaraan_Status_StatusID",
                table: "Kendaraan",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kendaraan_Status_StatusID",
                table: "Kendaraan");

            migrationBuilder.DropIndex(
                name: "IX_Kendaraan_StatusID",
                table: "Kendaraan");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Kendaraan");

            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "Kendaraan");

            migrationBuilder.DropColumn(
                name: "TahunPembuatan",
                table: "DokumenKendaraan");

            migrationBuilder.AddColumn<string>(
                name: "TahunPembuatan",
                table: "Kendaraan",
                type: "character varying(4)",
                maxLength: 4,
                nullable: true);
        }
    }
}
