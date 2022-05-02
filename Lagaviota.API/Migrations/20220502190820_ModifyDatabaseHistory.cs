using Microsoft.EntityFrameworkCore.Migrations;

namespace Lagaviota.API.Migrations
{
    public partial class ModifyDatabaseHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detail_Histrories_HistoryId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Histrories_Dog_DogId",
                table: "Histrories");

            migrationBuilder.DropIndex(
                name: "IX_Histrories_DogId",
                table: "Histrories");

            migrationBuilder.DropColumn(
                name: "DogId",
                table: "Histrories");

            migrationBuilder.AddColumn<int>(
                name: "HistoryId",
                table: "Procedures",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HistoryId",
                table: "Detail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "DogHistory",
                columns: table => new
                {
                    DogId = table.Column<int>(type: "int", nullable: false),
                    HistoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogHistory", x => new { x.DogId, x.HistoriesId });
                    table.ForeignKey(
                        name: "FK_DogHistory_Dog_DogId",
                        column: x => x.DogId,
                        principalTable: "Dog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DogHistory_Histrories_HistoriesId",
                        column: x => x.HistoriesId,
                        principalTable: "Histrories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_HistoryId",
                table: "Procedures",
                column: "HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DogHistory_HistoriesId",
                table: "DogHistory",
                column: "HistoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_Histrories_HistoryId",
                table: "Detail",
                column: "HistoryId",
                principalTable: "Histrories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Histrories_HistoryId",
                table: "Procedures",
                column: "HistoryId",
                principalTable: "Histrories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detail_Histrories_HistoryId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Histrories_HistoryId",
                table: "Procedures");

            migrationBuilder.DropTable(
                name: "DogHistory");

            migrationBuilder.DropIndex(
                name: "IX_Procedures_HistoryId",
                table: "Procedures");

            migrationBuilder.DropColumn(
                name: "HistoryId",
                table: "Procedures");

            migrationBuilder.AddColumn<int>(
                name: "DogId",
                table: "Histrories",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HistoryId",
                table: "Detail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Histrories_DogId",
                table: "Histrories",
                column: "DogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_Histrories_HistoryId",
                table: "Detail",
                column: "HistoryId",
                principalTable: "Histrories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Histrories_Dog_DogId",
                table: "Histrories",
                column: "DogId",
                principalTable: "Dog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
