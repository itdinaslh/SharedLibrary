using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharedLibrary.Migrations
{
    public partial class AlterNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Href",
                table: "Notifications",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Notifications",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Notifications",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Notifications",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Notifications");

            migrationBuilder.AlterColumn<string>(
                name: "Href",
                table: "Notifications",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
