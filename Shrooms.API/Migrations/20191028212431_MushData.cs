using Microsoft.EntityFrameworkCore.Migrations;

namespace Shrooms.Migrations
{
    public partial class MushData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mushrooms",
                columns: new[] { "MushroomId", "CapDimensions", "Family", "Name", "Poisonous", "Psycho", "Region", "SporePrintDetails", "StemDimensions", "VisualDetails" },
                values: new object[,]
                {
                    { 2, 6, "Stinkhorn", "Clathrus Ruber", true, false, "Southern Europe, Macronesia, Western Turkey, North Africa, Western Asia", "N/A", 14, "Round or oval hollow sphere, with latticed branches. Red or orange" },
                    { 3, 3, "Hymenogastraceae", "Psilocybe cyanescens", false, true, "Pacific Northwest, Western Europe, Central Europe, New Zealand and west Asia", "blackish-brown to purple", 7, "Cap is caramel to chestnut-brown when moist, fading to pale buff or slightly yellowish when dried. Stems are wavy. Parts of mushroom can turn blue when touched or disturbed" },
                    { 4, 3, "Hymenogastraceae", "Psilocybe cyanescens", false, true, "Pacific Northwest, Western Europe, Central Europe, New Zealand and west Asia", "blackish-brown to purple", 7, "Cap is caramel to chestnut-brown when moist, fading to pale buff or slightly yellowish when dried. Stems are wavy. Parts of mushroom can turn blue when touched or disturbed" },
                    { 5, 29, "Polyporaceae", "Polypore", false, false, "Globally in forested areas", "N/A", 29, "woody, shelf-like form, projecting straight out of tree trunks or logs." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 5);
        }
    }
}
