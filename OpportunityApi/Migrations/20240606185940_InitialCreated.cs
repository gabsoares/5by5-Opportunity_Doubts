using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpportunityApi.Migrations
{
    public partial class InitialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opportunity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SurgeLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoursAmount = table.Column<int>(type: "int", nullable: false),
                    ErrorsAmount = table.Column<long>(type: "bigint", nullable: false),
                    LearningLevel = table.Column<long>(type: "bigint", nullable: false),
                    SleepHours = table.Column<long>(type: "bigint", nullable: false),
                    OffHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opportunity", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Opportunity");
        }
    }
}