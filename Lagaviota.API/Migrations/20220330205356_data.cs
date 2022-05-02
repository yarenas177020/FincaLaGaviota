using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lagaviota.API.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Operators_OperatorId",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropIndex(
                name: "IX_Photo_OperatorId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "Photo");

            migrationBuilder.AddColumn<int>(
                name: "HistoryId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_Horses_HorseId",
                        column: x => x.HorseId,
                        principalTable: "Horses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DogHistory",
                columns: table => new
                {
                    DogsId = table.Column<int>(type: "int", nullable: false),
                    HistoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogHistory", x => new { x.DogsId, x.HistoriesId });
                    table.ForeignKey(
                        name: "FK_DogHistory_Dogs_DogsId",
                        column: x => x.DogsId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DogHistory_History_HistoriesId",
                        column: x => x.HistoriesId,
                        principalTable: "History",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HistoryId",
                table: "AspNetUsers",
                column: "HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DogHistory_HistoriesId",
                table: "DogHistory",
                column: "HistoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_History_HorseId",
                table: "History",
                column: "HorseId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_History_HistoryId",
                table: "AspNetUsers",
                column: "HistoryId",
                principalTable: "History",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_History_HistoryId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DogHistory");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_HistoryId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HistoryId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "OperatorId",
                table: "Photo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_OperatorId",
                table: "Photo",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Operators_Name",
                table: "Operators",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Operators_OperatorId",
                table: "Photo",
                column: "OperatorId",
                principalTable: "Operators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
