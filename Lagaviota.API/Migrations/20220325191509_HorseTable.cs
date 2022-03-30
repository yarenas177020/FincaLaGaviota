using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lagaviota.API.Migrations
{
    public partial class HorseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "animalTypes");

            migrationBuilder.AddColumn<int>(
                name: "HorseId",
                table: "Photo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Horses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BornDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_HorseId",
                table: "Photo",
                column: "HorseId");

            migrationBuilder.CreateIndex(
                name: "IX_Horses_Name",
                table: "Horses",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Horses_HorseId",
                table: "Photo",
                column: "HorseId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Horses_HorseId",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "Horses");

            migrationBuilder.DropIndex(
                name: "IX_Photo_HorseId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "HorseId",
                table: "Photo");

            migrationBuilder.CreateTable(
                name: "animalTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animalTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_animalTypes_Description",
                table: "animalTypes",
                column: "Description",
                unique: true);
        }
    }
}
