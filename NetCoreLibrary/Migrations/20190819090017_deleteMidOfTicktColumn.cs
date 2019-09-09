using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreLibrary.Migrations
{
    public partial class deleteMidOfTicktColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mid",
                table: "Tickts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "mid",
                table: "Tickts",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
