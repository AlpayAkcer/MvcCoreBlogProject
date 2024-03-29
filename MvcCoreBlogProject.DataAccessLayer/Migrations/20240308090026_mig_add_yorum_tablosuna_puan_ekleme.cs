﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCoreBlogProject.DataAccessLayer.Migrations
{
    public partial class mig_add_yorum_tablosuna_puan_ekleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Point",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Point",
                table: "Comments");
        }
    }
}
