using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseParty.Client.Migrations
{
    public partial class AddedQuestionUpdatedColumnInQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "QuestionUploaded",
                schema: "HouseParty",
                table: "Questions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionUploaded",
                schema: "HouseParty",
                table: "Questions");
        }
    }
}
