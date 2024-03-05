using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCoreBlogProject.DataAccessLayer.Migrations
{
    public partial class mig_update_blod_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Blogs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Blogs");
        }
    }
}
