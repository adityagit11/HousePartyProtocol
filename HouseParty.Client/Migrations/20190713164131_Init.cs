using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseParty.Client.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HouseParty");

            migrationBuilder.CreateTable(
                name: "Questions",
                schema: "HouseParty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    WhetherSeen = table.Column<bool>(nullable: false),
                    WhenSeen = table.Column<DateTime>(nullable: false),
                    WontDo = table.Column<bool>(nullable: false),
                    WontDoReason = table.Column<string>(nullable: true),
                    WhetherShubhiSubmitted = table.Column<bool>(nullable: false),
                    WhetherAdityaSubmitted = table.Column<bool>(nullable: false),
                    ShubhiSolution = table.Column<string>(nullable: true),
                    AdityaSolution = table.Column<string>(nullable: true),
                    QuestionUrl = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    SolutionSubmittedOn = table.Column<DateTime>(nullable: false),
                    SolutionUpdatedOn = table.Column<DateTime>(nullable: false),
                    QuestionType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions",
                schema: "HouseParty");
        }
    }
}
