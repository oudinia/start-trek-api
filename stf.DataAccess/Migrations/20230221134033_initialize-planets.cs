using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace stf.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initializeplanets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planet",
                columns: table => new
                {
                    PlanetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100, 100"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planet", x => x.PlanetId);
                });

            migrationBuilder.InsertData(
                table: "Planet",
                columns: new[] { "PlanetId", "Description", "Name" },
                values: new object[,]
                {
                    { 100, "A hot, arid planet with a harsh, rocky terrain. Home to the logical and stoic Vulcan species.", "Vulcan" },
                    { 200, "A beautiful planet covered in greenery and waterfalls. Home to the empathic Betazoid species.", "Betazed" },
                    { 300, "A harsh, volcanic planet with a toxic atmosphere. Home to the warrior Klingon species.", "Qo'noS" },
                    { 400, "A planet with a complex spiritual history and a strong connection to the Bajoran species' religion.", "Bajor" },
                    { 500, "A frozen planet with icy terrain and harsh weather conditions. Home to the blue-skinned Andorian species.", "Andoria" },
                    { 600, "A tropical paradise planet known for its beaches, resorts, and hedonistic culture.", "Risa" },
                    { 700, "A planet with a militaristic society and a complicated political landscape. Home to the Cardassian species.", "Cardassia Prime" },
                    { 800, "A planet known for its vast wealth and a culture centered around the accumulation of wealth. Home to the Ferengi species.", "Ferenginar" },
                    { 900, "A planet with a secretive and militaristic society. Home to the Romulan species.", "Romulus" },
                    { 1000, "A planet with a highly-developed infrastructure and a strong focus on scientific exploration. Home to the Tellarite species.", "Tellar Prime" },
                    { 1100, "A planet with a unique symbiotic species that coexists with humanoid hosts. Home to the Trill species.", "Trill" },
                    { 1200, "A planet with a hierarchical and highly-structured society. Home to the genetically-engineered Vorta species.", "Vorta Vor" },
                    { 1300, "A planet with an enigmatic and mysterious species. Little is known about the Breen and their home world.", "Breen" },
                    { 1400, "A planet with a highly-developed and technologically-advanced society. Home to the Talaxian species.", "Talax" },
                    { 1500, "A planet with a warlike and territorial species. Home to the lizard-like Gorn species.", "Gornar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planet");
        }
    }
}
