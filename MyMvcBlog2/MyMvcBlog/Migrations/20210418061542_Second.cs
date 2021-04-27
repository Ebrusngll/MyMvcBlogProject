using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMvcBlog.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentTitle",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Articles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentTitle",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Articles");
        }
    }
}
