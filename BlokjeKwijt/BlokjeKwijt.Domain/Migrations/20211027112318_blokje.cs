using Microsoft.EntityFrameworkCore.Migrations;

namespace BlokjeKwijt.Domain.Migrations
{
    public partial class blokje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlokjeColors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RgbValue = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlokjeColors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Blokjes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lenght = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    ColorID = table.Column<int>(type: "int", nullable: true),
                    NumberOfNobs = table.Column<int>(type: "int", nullable: false),
                    BlockNumber = table.Column<int>(type: "int", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blokjes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Blokjes_BlokjeColors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "BlokjeColors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactForms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContactForms_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserHasExtraBricks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    BlokjeID = table.Column<int>(type: "int", nullable: true),
                    Solved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHasExtraBricks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserHasExtraBricks_Blokjes_BlokjeID",
                        column: x => x.BlokjeID,
                        principalTable: "Blokjes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserHasExtraBricks_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserHasMissingBricks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    BLokjeID = table.Column<int>(type: "int", nullable: true),
                    Solved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHasMissingBricks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserHasMissingBricks_Blokjes_BLokjeID",
                        column: x => x.BLokjeID,
                        principalTable: "Blokjes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserHasMissingBricks_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blokjes_ColorID",
                table: "Blokjes",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactForms_UserID",
                table: "ContactForms",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserHasExtraBricks_BlokjeID",
                table: "UserHasExtraBricks",
                column: "BlokjeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserHasExtraBricks_UserID",
                table: "UserHasExtraBricks",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserHasMissingBricks_BLokjeID",
                table: "UserHasMissingBricks",
                column: "BLokjeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserHasMissingBricks_UserID",
                table: "UserHasMissingBricks",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactForms");

            migrationBuilder.DropTable(
                name: "UserHasExtraBricks");

            migrationBuilder.DropTable(
                name: "UserHasMissingBricks");

            migrationBuilder.DropTable(
                name: "Blokjes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BlokjeColors");
        }
    }
}
