using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shrooms.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mushrooms",
                columns: table => new
                {
                    MushroomId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    family = table.Column<string>(nullable: true),
                    Psycho = table.Column<bool>(nullable: false),
                    Poisonous = table.Column<bool>(nullable: false),
                    Region = table.Column<string>(nullable: true),
                    SporePrintDetails = table.Column<string>(nullable: true),
                    VisualDetails = table.Column<string>(nullable: true),
                    CapDimensions = table.Column<int>(nullable: false),
                    StemDimensions = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mushrooms", x => x.MushroomId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mushrooms");
        }
    }
}
