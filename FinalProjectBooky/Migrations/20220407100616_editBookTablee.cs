using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectBooky.Migrations
{
    public partial class editBookTablee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "InStock",
                table: "Books",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SkuCode",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "SkuCode",
                table: "Books");
        }
    }
}
