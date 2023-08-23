using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokedexRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class superdbtestpt3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenerationVII_Icons_IconsId",
                table: "GenerationVII");

            migrationBuilder.DropForeignKey(
                name: "FK_GenerationVIII_Icons_IconsId",
                table: "GenerationVIII");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_HeldItems_Held_ItemId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_VersionDetails_HeldItems_Held_ItemId",
                table: "VersionDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_VersionDetails_Version_VersionId",
                table: "VersionDetails");

            migrationBuilder.DropTable(
                name: "Icons");

            migrationBuilder.DropIndex(
                name: "IX_VersionGroupDetails_MovesId",
                table: "VersionGroupDetails");

            migrationBuilder.DropIndex(
                name: "IX_VersionDetails_Held_ItemId",
                table: "VersionDetails");

            migrationBuilder.DropIndex(
                name: "IX_GenerationVIII_IconsId",
                table: "GenerationVIII");

            migrationBuilder.DropIndex(
                name: "IX_GenerationVII_IconsId",
                table: "GenerationVII");

            migrationBuilder.DropIndex(
                name: "IX_Ability_AbilitiesId",
                table: "Ability");

            migrationBuilder.DropColumn(
                name: "Held_ItemId",
                table: "VersionDetails");

            migrationBuilder.DropColumn(
                name: "IconsId",
                table: "GenerationVIII");

            migrationBuilder.DropColumn(
                name: "IconsId",
                table: "GenerationVII");

            migrationBuilder.RenameColumn(
                name: "VersionId",
                table: "VersionDetails",
                newName: "Held_ItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_VersionDetails_VersionId",
                table: "VersionDetails",
                newName: "IX_VersionDetails_Held_ItemsId");

            migrationBuilder.RenameColumn(
                name: "Held_ItemId",
                table: "Item",
                newName: "Held_ItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_Held_ItemId",
                table: "Item",
                newName: "IX_Item_Held_ItemsId");

            migrationBuilder.AddColumn<int>(
                name: "PokemondId",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Icons_vii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_viiId = table.Column<int>(type: "int", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icons_vii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Icons_vii_GenerationVII_Generation_viiId",
                        column: x => x.Generation_viiId,
                        principalTable: "GenerationVII",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Icons_viii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_viiiId = table.Column<int>(type: "int", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icons_viii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Icons_viii_GenerationVIII_Generation_viiiId",
                        column: x => x.Generation_viiiId,
                        principalTable: "GenerationVIII",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemVersion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version_DetailsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemVersion_VersionDetails_Version_DetailsId",
                        column: x => x.Version_DetailsId,
                        principalTable: "VersionDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VersionGroupDetails_MovesId",
                table: "VersionGroupDetails",
                column: "MovesId");

            migrationBuilder.CreateIndex(
                name: "IX_Types_PokemonId",
                table: "Types",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_PokemonId",
                table: "Stats",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprites_PokemonId",
                table: "Sprites",
                column: "PokemonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Species_PokemonId",
                table: "Species",
                column: "PokemonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PastTypes_PokemonId",
                table: "PastTypes",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_PokemonId",
                table: "Moves",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_HeldItems_PokemonId",
                table: "HeldItems",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_GameIndices_PokemonId",
                table: "GameIndices",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_PokemonId",
                table: "Forms",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_AbilitiesId",
                table: "Ability",
                column: "AbilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Icons_vii_Generation_viiId",
                table: "Icons_vii",
                column: "Generation_viiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Icons_viii_Generation_viiiId",
                table: "Icons_viii",
                column: "Generation_viiiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemVersion_Version_DetailsId",
                table: "ItemVersion",
                column: "Version_DetailsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_Pokemons_PokemonId",
                table: "Forms",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameIndices_Pokemons_PokemonId",
                table: "GameIndices",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeldItems_Pokemons_PokemonId",
                table: "HeldItems",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_HeldItems_Held_ItemsId",
                table: "Item",
                column: "Held_ItemsId",
                principalTable: "HeldItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Moves_Pokemons_PokemonId",
                table: "Moves",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PastTypes_Pokemons_PokemonId",
                table: "PastTypes",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Species_Pokemons_PokemonId",
                table: "Species",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sprites_Pokemons_PokemonId",
                table: "Sprites",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stats_Pokemons_PokemonId",
                table: "Stats",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Types_Pokemons_PokemonId",
                table: "Types",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VersionDetails_HeldItems_Held_ItemsId",
                table: "VersionDetails",
                column: "Held_ItemsId",
                principalTable: "HeldItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_Pokemons_PokemonId",
                table: "Forms");

            migrationBuilder.DropForeignKey(
                name: "FK_GameIndices_Pokemons_PokemonId",
                table: "GameIndices");

            migrationBuilder.DropForeignKey(
                name: "FK_HeldItems_Pokemons_PokemonId",
                table: "HeldItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_HeldItems_Held_ItemsId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Moves_Pokemons_PokemonId",
                table: "Moves");

            migrationBuilder.DropForeignKey(
                name: "FK_PastTypes_Pokemons_PokemonId",
                table: "PastTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Species_Pokemons_PokemonId",
                table: "Species");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprites_Pokemons_PokemonId",
                table: "Sprites");

            migrationBuilder.DropForeignKey(
                name: "FK_Stats_Pokemons_PokemonId",
                table: "Stats");

            migrationBuilder.DropForeignKey(
                name: "FK_Types_Pokemons_PokemonId",
                table: "Types");

            migrationBuilder.DropForeignKey(
                name: "FK_VersionDetails_HeldItems_Held_ItemsId",
                table: "VersionDetails");

            migrationBuilder.DropTable(
                name: "Icons_vii");

            migrationBuilder.DropTable(
                name: "Icons_viii");

            migrationBuilder.DropTable(
                name: "ItemVersion");

            migrationBuilder.DropIndex(
                name: "IX_VersionGroupDetails_MovesId",
                table: "VersionGroupDetails");

            migrationBuilder.DropIndex(
                name: "IX_Types_PokemonId",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Stats_PokemonId",
                table: "Stats");

            migrationBuilder.DropIndex(
                name: "IX_Sprites_PokemonId",
                table: "Sprites");

            migrationBuilder.DropIndex(
                name: "IX_Species_PokemonId",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_PastTypes_PokemonId",
                table: "PastTypes");

            migrationBuilder.DropIndex(
                name: "IX_Moves_PokemonId",
                table: "Moves");

            migrationBuilder.DropIndex(
                name: "IX_HeldItems_PokemonId",
                table: "HeldItems");

            migrationBuilder.DropIndex(
                name: "IX_GameIndices_PokemonId",
                table: "GameIndices");

            migrationBuilder.DropIndex(
                name: "IX_Forms_PokemonId",
                table: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Ability_AbilitiesId",
                table: "Ability");

            migrationBuilder.DropColumn(
                name: "PokemondId",
                table: "Stats");

            migrationBuilder.RenameColumn(
                name: "Held_ItemsId",
                table: "VersionDetails",
                newName: "VersionId");

            migrationBuilder.RenameIndex(
                name: "IX_VersionDetails_Held_ItemsId",
                table: "VersionDetails",
                newName: "IX_VersionDetails_VersionId");

            migrationBuilder.RenameColumn(
                name: "Held_ItemsId",
                table: "Item",
                newName: "Held_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_Held_ItemsId",
                table: "Item",
                newName: "IX_Item_Held_ItemId");

            migrationBuilder.AddColumn<int>(
                name: "Held_ItemId",
                table: "VersionDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IconsId",
                table: "GenerationVIII",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IconsId",
                table: "GenerationVII",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Icons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenerationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icons", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VersionGroupDetails_MovesId",
                table: "VersionGroupDetails",
                column: "MovesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VersionDetails_Held_ItemId",
                table: "VersionDetails",
                column: "Held_ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVIII_IconsId",
                table: "GenerationVIII",
                column: "IconsId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVII_IconsId",
                table: "GenerationVII",
                column: "IconsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_AbilitiesId",
                table: "Ability",
                column: "AbilitiesId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GenerationVII_Icons_IconsId",
                table: "GenerationVII",
                column: "IconsId",
                principalTable: "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenerationVIII_Icons_IconsId",
                table: "GenerationVIII",
                column: "IconsId",
                principalTable: "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_HeldItems_Held_ItemId",
                table: "Item",
                column: "Held_ItemId",
                principalTable: "HeldItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VersionDetails_HeldItems_Held_ItemId",
                table: "VersionDetails",
                column: "Held_ItemId",
                principalTable: "HeldItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VersionDetails_Version_VersionId",
                table: "VersionDetails",
                column: "VersionId",
                principalTable: "Version",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
