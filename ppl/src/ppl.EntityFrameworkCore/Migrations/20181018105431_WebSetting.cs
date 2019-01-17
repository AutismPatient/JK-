using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ppl.Migrations
{
    public partial class WebSetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HomeUrlTitle = table.Column<string>(nullable: true),
                    KeyWord = table.Column<string>(nullable: true),
                    Describe = table.Column<string>(nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false),
                    IconUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebSettings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebSettings");
        }
    }
}
