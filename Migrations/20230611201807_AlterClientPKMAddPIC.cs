using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharedLibrary.Migrations
{
    public partial class AlterClientPKMAddPIC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NoHpPIC",
                table: "ClientPkm",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PIC",
                table: "ClientPkm",
                type: "character varying(75)",
                maxLength: 75,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoHpPIC",
                table: "ClientPkm");

            migrationBuilder.DropColumn(
                name: "PIC",
                table: "ClientPkm");
        }
    }
}
