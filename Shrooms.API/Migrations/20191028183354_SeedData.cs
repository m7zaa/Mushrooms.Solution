using Microsoft.EntityFrameworkCore.Migrations;

namespace Shrooms.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "family",
                table: "Mushrooms",
                newName: "Family");

            migrationBuilder.InsertData(
                table: "Mushrooms",
                columns: new[] { "MushroomId", "CapDimensions", "Family", "Name", "Poisonous", "Psycho", "Region", "SporePrintDetails", "StemDimensions", "VisualDetails" },
                values: new object[] { 1, 9, "Pluteaceae", "Fly Amanita", true, true, "North America, Europe, Asia", "na", 13, "white stem, red cap with white spots" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Family",
                table: "Mushrooms",
                newName: "family");
        }
    }
}
