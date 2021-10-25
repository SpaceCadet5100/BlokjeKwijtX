using Microsoft.EntityFrameworkCore.Migrations;

namespace BlokjeKwijt.Domain.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blokjes_BlokjeColors_ColorID",
                table: "Blokjes");

            migrationBuilder.DropIndex(
                name: "IX_Blokjes_ColorID",
                table: "Blokjes");

            migrationBuilder.DropColumn(
                name: "ColorID",
                table: "Blokjes");

            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "Blokjes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Blokjes");

            migrationBuilder.AddColumn<int>(
                name: "ColorID",
                table: "Blokjes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blokjes_ColorID",
                table: "Blokjes",
                column: "ColorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blokjes_BlokjeColors_ColorID",
                table: "Blokjes",
                column: "ColorID",
                principalTable: "BlokjeColors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
