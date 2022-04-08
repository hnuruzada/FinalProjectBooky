using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectBooky.Migrations
{
    public partial class changeCategoryAndBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Blogs_BlogId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_BlogId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryId",
                table: "Blogs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BlogId",
                table: "Categories",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Blogs_BlogId",
                table: "Categories",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
