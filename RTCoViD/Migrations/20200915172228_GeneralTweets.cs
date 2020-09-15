using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RTCoViD.Migrations
{
    public partial class GeneralTweets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralTweets",
                columns: table => new
                {
                    TweetId = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralTweets", x => x.TweetId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralTweets");
        }
    }
}
