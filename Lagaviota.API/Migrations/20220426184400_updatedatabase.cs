using Microsoft.EntityFrameworkCore.Migrations;

namespace Lagaviota.API.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detail_Procedures_ProcedureId",
                table: "Detail");

            migrationBuilder.DropIndex(
                name: "IX_Detail_ProcedureId",
                table: "Detail");

            migrationBuilder.DropColumn(
                name: "ProcedureId",
                table: "Detail");

            migrationBuilder.CreateTable(
                name: "DetailProcedure",
                columns: table => new
                {
                    DetailsId = table.Column<int>(type: "int", nullable: false),
                    ProceduresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailProcedure", x => new { x.DetailsId, x.ProceduresId });
                    table.ForeignKey(
                        name: "FK_DetailProcedure_Detail_DetailsId",
                        column: x => x.DetailsId,
                        principalTable: "Detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailProcedure_Procedures_ProceduresId",
                        column: x => x.ProceduresId,
                        principalTable: "Procedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailProcedure_ProceduresId",
                table: "DetailProcedure",
                column: "ProceduresId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailProcedure");

            migrationBuilder.AddColumn<int>(
                name: "ProcedureId",
                table: "Detail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Detail_ProcedureId",
                table: "Detail",
                column: "ProcedureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_Procedures_ProcedureId",
                table: "Detail",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
