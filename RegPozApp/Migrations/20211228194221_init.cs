using Microsoft.EntityFrameworkCore.Migrations;

namespace RegPozApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureId1 = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Values_Features_FeatureId1",
                        column: x => x.FeatureId1,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Reikia atlikti rangos darbus" },
                    { 2, false, "Rangos darbus atliks" },
                    { 3, false, "Verslo klientas" },
                    { 4, false, "Skaičiavimo metodas" },
                    { 5, false, "Svarbus klientas" }
                });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "FeatureId1", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 10, null, false, "Rankinis" },
                    { 9, null, false, "Automatinis" },
                    { 8, null, false, "Ne" },
                    { 7, null, false, "Taip" },
                    { 6, null, false, "Naujas rangovas" },
                    { 4, null, false, "Metinis subrangovas" },
                    { 11, null, false, "Taip" },
                    { 3, null, false, "Metinis rangovas" },
                    { 2, null, false, "Ne" },
                    { 1, null, false, "Taip" },
                    { 5, null, false, "Senas rangovas" },
                    { 12, null, false, "Ne" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Values_FeatureId1",
                table: "Values",
                column: "FeatureId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Values");

            migrationBuilder.DropTable(
                name: "Features");
        }
    }
}
