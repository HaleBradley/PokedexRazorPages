using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokedexRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class AddPokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PokemonId",
                table: "Rating",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PokemonId",
                table: "Rating");
        }
    }
}
