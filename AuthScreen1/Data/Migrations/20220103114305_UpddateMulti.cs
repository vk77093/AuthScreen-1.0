using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthScreen1.Data.Migrations
{
    public partial class UpddateMulti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "NameTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pincode",
                table: "NameTables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "NameTables",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "NameTables");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "NameTables");

            migrationBuilder.DropColumn(
                name: "State",
                table: "NameTables");
        }
    }
}
