using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseParty.Client.Migrations
{
    public partial class UpdatedQuestionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SolutionUpdatedOn",
                schema: "HouseParty",
                table: "Questions",
                newName: "ShubhiSolutionUpdatedOn");

            migrationBuilder.RenameColumn(
                name: "SolutionSubmittedOn",
                schema: "HouseParty",
                table: "Questions",
                newName: "ShubhiSolutionSubmittedOn");

            migrationBuilder.AddColumn<DateTime>(
                name: "AdityaSolutionSubmittedOn",
                schema: "HouseParty",
                table: "Questions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AdityaSolutionUpdatedOn",
                schema: "HouseParty",
                table: "Questions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdityaSolutionSubmittedOn",
                schema: "HouseParty",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AdityaSolutionUpdatedOn",
                schema: "HouseParty",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "ShubhiSolutionUpdatedOn",
                schema: "HouseParty",
                table: "Questions",
                newName: "SolutionUpdatedOn");

            migrationBuilder.RenameColumn(
                name: "ShubhiSolutionSubmittedOn",
                schema: "HouseParty",
                table: "Questions",
                newName: "SolutionSubmittedOn");
        }
    }
}
