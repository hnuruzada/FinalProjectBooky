using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectBooky.Migrations
{
    public partial class editPublisherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Publishers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Publishers");
        }
    }
}
