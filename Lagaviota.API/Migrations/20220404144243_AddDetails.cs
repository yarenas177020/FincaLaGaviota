using Microsoft.EntityFrameworkCore.Migrations;

namespace Lagaviota.API.Migrations
{
    public partial class AddDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_History_HistoryId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DogHistory");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_HistoryId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HistoryId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "RegisterDate",
                table: "History",
                newName: "Date");

            migrationBuilder.AddColumn<int>(
                name: "DogId",
                table: "History",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "History",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistoryId = table.Column<int>(type: "int", nullable: false),
                    ProcedureId = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detail_History_HistoryId",
                        column: x => x.HistoryId,
                        principalTable: "History",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detail_Procedures_ProcedureId",
                        column: x => x.ProcedureId,
                        principalTable: "Procedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_History_DogId",
                table: "History",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_HistoryId",
                table: "Detail",
                column: "HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_ProcedureId",
                table: "Detail",
                column: "ProcedureId");

            migrationBuilder.AddForeignKey(
                name: "FK_History_Dogs_DogId",
                table: "History",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_Dogs_DogId",
                table: "History");

            migrationBuilder.DropTable(
                name: "Detail");

            migrationBuilder.DropIndex(
                name: "IX_History_DogId",
                table: "History");

            migrationBuilder.DropColumn(
                name: "DogId",
                table: "History");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "History");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "History",
                newName: "RegisterDate");

            migrationBuilder.AddColumn<int>(
                name: "HistoryId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_History_HistoryId",
                table: "AspNetUsers",
                column: "HistoryId",
                principalTable: "History",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
