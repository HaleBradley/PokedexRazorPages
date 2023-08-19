using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokedexRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class Supertestpt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Abilities_PokemonId",
                table: "Abilities",
                column: "PokemonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abilities_Pokemons_PokemonId",
                table: "Abilities",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abilities_Pokemons_PokemonId",
                table: "Abilities");

            migrationBuilder.DropIndex(
                name: "IX_Abilities_PokemonId",
                table: "Abilities");
        }
    }
}
