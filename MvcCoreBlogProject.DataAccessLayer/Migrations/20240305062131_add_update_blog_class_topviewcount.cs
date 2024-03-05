using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCoreBlogProject.DataAccessLayer.Migrations
{
    public partial class add_update_blog_class_topviewcount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TopViewCount",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopViewCount",
                table: "Blogs");
        }
    }
}
