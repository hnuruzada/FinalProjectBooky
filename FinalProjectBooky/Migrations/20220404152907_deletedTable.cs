using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectBooky.Migrations
{
    public partial class deletedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Publishers_PublisherId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Publishers_PublisherId",
                table: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_PublisherId",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_PublisherId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Resume = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_PublisherId",
                table: "SocialMedias",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_PublisherId",
                table: "Blogs",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Publishers_PublisherId",
                table: "Blogs",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Publishers_PublisherId",
                table: "SocialMedias",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
