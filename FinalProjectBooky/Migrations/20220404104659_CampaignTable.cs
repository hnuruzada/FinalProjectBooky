using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectBooky.Migrations
{
    public partial class CampaignTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampaignId",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountPercent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CampaignId",
                table: "Books",
                column: "CampaignId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Campaigns_CampaignId",
                table: "Books",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Campaigns_CampaignId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Books_CampaignId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CampaignId",
                table: "Books");
        }
    }
}
