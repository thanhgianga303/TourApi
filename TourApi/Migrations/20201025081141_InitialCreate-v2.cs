using Microsoft.EntityFrameworkCore.Migrations;

namespace TourApi.Migrations
{
    public partial class InitialCreatev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InOrder",
                table: "TourDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InOrder",
                table: "TourDetails");
        }
    }
}
