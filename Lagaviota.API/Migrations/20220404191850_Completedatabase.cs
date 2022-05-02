using Microsoft.EntityFrameworkCore.Migrations;

namespace Lagaviota.API.Migrations
{
    public partial class Completedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detail_History_HistoryId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_History_Dogs_DogId",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_History_Horses_HorseId",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Dogs_DogId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Horses_HorseId",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photo",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_History",
                table: "History");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dogs",
                table: "Dogs");

            migrationBuilder.RenameTable(
                name: "Photo",
                newName: "Photos");

            migrationBuilder.RenameTable(
                name: "History",
                newName: "Histrories");

            migrationBuilder.RenameTable(
                name: "Dogs",
                newName: "Dog");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_HorseId",
                table: "Photos",
                newName: "IX_Photos_HorseId");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_DogId",
                table: "Photos",
                newName: "IX_Photos_DogId");

            migrationBuilder.RenameIndex(
                name: "IX_History_HorseId",
                table: "Histrories",
                newName: "IX_Histrories_HorseId");

            migrationBuilder.RenameIndex(
                name: "IX_History_DogId",
                table: "Histrories",
                newName: "IX_Histrories_DogId");

            migrationBuilder.RenameIndex(
                name: "IX_Dogs_Name",
                table: "Dog",
                newName: "IX_Dog_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Histrories",
                table: "Histrories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dog",
                table: "Dog",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Histrories_Horses_HorseId",
                table: "Histrories",
                column: "HorseId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Dog_DogId",
                table: "Photos",
                column: "DogId",
                principalTable: "Dog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Horses_HorseId",
                table: "Photos",
                column: "HorseId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detail_Histrories_HistoryId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Histrories_Dog_DogId",
                table: "Histrories");

            migrationBuilder.DropForeignKey(
                name: "FK_Histrories_Horses_HorseId",
                table: "Histrories");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Dog_DogId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Horses_HorseId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Histrories",
                table: "Histrories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dog",
                table: "Dog");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Photo");

            migrationBuilder.RenameTable(
                name: "Histrories",
                newName: "History");

            migrationBuilder.RenameTable(
                name: "Dog",
                newName: "Dogs");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_HorseId",
                table: "Photo",
                newName: "IX_Photo_HorseId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_DogId",
                table: "Photo",
                newName: "IX_Photo_DogId");

            migrationBuilder.RenameIndex(
                name: "IX_Histrories_HorseId",
                table: "History",
                newName: "IX_History_HorseId");

            migrationBuilder.RenameIndex(
                name: "IX_Histrories_DogId",
                table: "History",
                newName: "IX_History_DogId");

            migrationBuilder.RenameIndex(
                name: "IX_Dog_Name",
                table: "Dogs",
                newName: "IX_Dogs_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photo",
                table: "Photo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_History",
                table: "History",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dogs",
                table: "Dogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_History_HistoryId",
                table: "Detail",
                column: "HistoryId",
                principalTable: "History",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_History_Dogs_DogId",
                table: "History",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_History_Horses_HorseId",
                table: "History",
                column: "HorseId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Dogs_DogId",
                table: "Photo",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Horses_HorseId",
                table: "Photo",
                column: "HorseId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
