using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectBooky.Migrations
{
    public partial class SettingAndFooterSocialMediaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(maxLength: 150, nullable: false),
                    WebName = table.Column<string>(maxLength: 40, nullable: false),
                    ParallaxImage = table.Column<string>(nullable: true),
                    FooterImage = table.Column<string>(nullable: true),
                    PhoneNumber1 = table.Column<string>(maxLength: 30, nullable: false),
                    PhoneNumber2 = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FooterSocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(maxLength: 150, nullable: false),
                    Url = table.Column<string>(maxLength: 250, nullable: false),
                    SettingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterSocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FooterSocialMedias_Settings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BlogId",
                table: "Categories",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_FooterSocialMedias_SettingId",
                table: "FooterSocialMedias",
                column: "SettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Blogs_BlogId",
                table: "Categories",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Blogs_BlogId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "FooterSocialMedias");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropIndex(
                name: "IX_Categories_BlogId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Categories");
        }
    }
}
