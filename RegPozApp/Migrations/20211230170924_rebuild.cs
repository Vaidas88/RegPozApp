using Microsoft.EntityFrameworkCore.Migrations;

namespace RegPozApp.Migrations
{
    public partial class rebuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AnswerId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, 1, false, "Reikia atlikti rangos darbus" },
                    { 2, 3, false, "Rangos darbus atliks" },
                    { 3, 8, false, "Verslo klientas" },
                    { 4, 9, false, "Skaičiavimo metodas" },
                    { 5, 0, false, "Svarbus klientas" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsDeleted", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 1, false, "Taip", 1 },
                    { 2, false, "Ne", 1 },
                    { 3, false, "Metinis rangovas", 2 },
                    { 4, false, "Metinis subrangovas", 2 },
                    { 5, false, "Senas rangovas", 2 },
                    { 6, false, "Naujas rangovas", 2 },
                    { 7, false, "Taip", 3 },
                    { 8, false, "Ne", 3 },
                    { 9, false, "Automatinis", 4 },
                    { 10, false, "Rankinis", 4 },
                    { 11, false, "Taip", 5 },
                    { 12, false, "Ne", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
