using Microsoft.EntityFrameworkCore.Migrations;

namespace Shrooms.Migrations
{
    public partial class NewMushData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 4,
                columns: new[] { "CapDimensions", "Family", "Name", "Psycho", "Region", "SporePrintDetails", "StemDimensions", "VisualDetails" },
                values: new object[] { 29, "Polyporaceae", "Polypore", false, "Globally in forested areas", "N/A", 29, "woody, shelf-like form, projecting straight out of tree trunks or logs." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 4,
                columns: new[] { "CapDimensions", "Family", "Name", "Psycho", "Region", "SporePrintDetails", "StemDimensions", "VisualDetails" },
                values: new object[] { 3, "Hymenogastraceae", "Psilocybe cyanescens", true, "Pacific Northwest, Western Europe, Central Europe, New Zealand and west Asia", "blackish-brown to purple", 7, "Cap is caramel to chestnut-brown when moist, fading to pale buff or slightly yellowish when dried. Stems are wavy. Parts of mushroom can turn blue when touched or disturbed" });

            migrationBuilder.InsertData(
                table: "Mushrooms",
                columns: new[] { "MushroomId", "CapDimensions", "Family", "Name", "Poisonous", "Psycho", "Region", "SporePrintDetails", "StemDimensions", "VisualDetails" },
                values: new object[] { 5, 29, "Polyporaceae", "Polypore", false, false, "Globally in forested areas", "N/A", 29, "woody, shelf-like form, projecting straight out of tree trunks or logs." });
        }
    }
}
