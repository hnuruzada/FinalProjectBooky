using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectBooky.Migrations
{
    public partial class PublisherAndSocialMediaTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Surname = table.Column<string>(maxLength: 30, nullable: false),
                    Resume = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(maxLength: 150, nullable: false),
                    Url = table.Column<string>(maxLength: 250, nullable: false),
                    PublisherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedias_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_PublisherId",
                table: "Blogs",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_PublisherId",
                table: "SocialMedias",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Publishers_PublisherId",
                table: "Blogs",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Publishers_PublisherId",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_PublisherId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Blogs");
        }
    }
}
