using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoNetcore.Migrations
{
    public partial class update_hocsinh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Hocsinh",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Hocsinh");
        }
    }
}
