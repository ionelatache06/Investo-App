using Microsoft.EntityFrameworkCore.Migrations;

namespace App.API.Migrations
{
    public partial class ExtraUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Income",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Industry",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Story",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Testimonials",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "USP",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Income",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Story",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Testimonials",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "USP",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Video",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Users");
        }
    }
}
