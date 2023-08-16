using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokedexRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class ExperimentalDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbilityObj",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    Slot = table.Column<int>(type: "int", nullable: false),
                    PokemonId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityObj", x => x.PokemonId);
                    table.ForeignKey(
                        name: "FK_AbilityObj_Pokemons_PokemonId1",
                        column: x => x.PokemonId1,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpriteObj",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpriteObj", x => x.PokemonId);
                    table.ForeignKey(
                        name: "FK_SpriteObj_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeObj",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slot = table.Column<int>(type: "int", nullable: false),
                    PokemonId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeObj", x => x.PokemonId);
                    table.ForeignKey(
                        name: "FK_TypeObj_Pokemons_PokemonId1",
                        column: x => x.PokemonId1,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityObj_PokemonId1",
                table: "AbilityObj",
                column: "PokemonId1");

            migrationBuilder.CreateIndex(
                name: "IX_TypeObj_PokemonId1",
                table: "TypeObj",
                column: "PokemonId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityObj");

            migrationBuilder.DropTable(
                name: "SpriteObj");

            migrationBuilder.DropTable(
                name: "TypeObj");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
