using Microsoft.EntityFrameworkCore.Migrations;

namespace RegPozApp.Migrations
{
    public partial class formmodelcorrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Forms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsDeleted", "Name" },
                values: new object[] { false, "Form #1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Forms");
        }
    }
}
