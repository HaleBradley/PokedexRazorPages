using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokedexRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class Supertest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityObj");

            migrationBuilder.DropTable(
                name: "SpriteObj");

            migrationBuilder.DropTable(
                name: "TypeObj");

            migrationBuilder.DropTable(
                name: "Sprite");

            migrationBuilder.DropTable(
                name: "Art");

            migrationBuilder.AddColumn<int>(
                name: "Base_Experience",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "Pokemons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Location_Area_Encounters",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AbilitiesId",
                table: "Ability",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Is_Hidden = table.Column<bool>(type: "bit", nullable: false),
                    Slot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameIndices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Game_Index = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameIndices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeldItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeldItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Icons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenerationId = table.Column<int>(type: "int", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sprites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Base_Stat = table.Column<int>(type: "int", nullable: false),
                    Effort = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Slot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Game_IndicesId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Version_GameIndices_Game_IndicesId",
                        column: x => x.Game_IndicesId,
                        principalTable: "GameIndices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Held_ItemId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_HeldItems_Held_ItemId",
                        column: x => x.Held_ItemId,
                        principalTable: "HeldItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Move",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovesId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Move", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Move_Moves_MovesId",
                        column: x => x.MovesId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VersionGroupDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovesId = table.Column<int>(type: "int", nullable: false),
                    Level_Learned_At = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionGroupDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionGroupDetails_Moves_MovesId",
                        column: x => x.MovesId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Other",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpritesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Other", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Other_Sprites_SpritesId",
                        column: x => x.SpritesId,
                        principalTable: "Sprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpritesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Versions_Sprites_SpritesId",
                        column: x => x.SpritesId,
                        principalTable: "Sprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stat_Stats_StatsId",
                        column: x => x.StatsId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PastTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    TypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PastTypes_Types_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypesId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Type_Types_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VersionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Held_ItemId = table.Column<int>(type: "int", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    VersionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionDetails_HeldItems_Held_ItemId",
                        column: x => x.Held_ItemId,
                        principalTable: "HeldItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionDetails_Version_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Version",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoveLearnMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version_Group_DetailsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveLearnMethod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveLearnMethod_VersionGroupDetails_Version_Group_DetailsId",
                        column: x => x.Version_Group_DetailsId,
                        principalTable: "VersionGroupDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VersionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version_Group_DetailsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionGroup_VersionGroupDetails_Version_Group_DetailsId",
                        column: x => x.Version_Group_DetailsId,
                        principalTable: "VersionGroupDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DreamWorld",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherId = table.Column<int>(type: "int", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DreamWorld", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DreamWorld_Other_OtherId",
                        column: x => x.OtherId,
                        principalTable: "Other",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherId = table.Column<int>(type: "int", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Home_Other_OtherId",
                        column: x => x.OtherId,
                        principalTable: "Other",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficialArtwork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherId = table.Column<int>(type: "int", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialArtwork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficialArtwork_Other_OtherId",
                        column: x => x.OtherId,
                        principalTable: "Other",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationI", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationI_Versions_VersionsId",
                        column: x => x.VersionsId,
                        principalTable: "Versions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationII",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationII", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationII_Versions_VersionsId",
                        column: x => x.VersionsId,
                        principalTable: "Versions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationIII",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationIII", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationIII_Versions_VersionsId",
                        column: x => x.VersionsId,
                        principalTable: "Versions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationIV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationIV", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationIV_Versions_VersionsId",
                        column: x => x.VersionsId,
                        principalTable: "Versions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationV", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationV_Versions_VersionsId",
                        column: x => x.VersionsId,
                        principalTable: "Versions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationVI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationVI", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationVI_Versions_VersionsId",
                        column: x => x.VersionsId,
                        principalTable: "Versions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationVII",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionsId = table.Column<int>(type: "int", nullable: false),
                    IconsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationVII", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationVII_Icons_IconsId",
                        column: x => x.IconsId,
                        principalTable: "Icons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationVII_Versions_VersionsId",
                        column: x => x.VersionsId,
                        principalTable: "Versions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationVIII",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionsId = table.Column<int>(type: "int", nullable: false),
                    IconsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationVIII", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerationVIII_Icons_IconsId",
                        column: x => x.IconsId,
                        principalTable: "Icons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationVIII_Versions_VersionsId",
                        column: x => x.VersionsId,
                        principalTable: "Versions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Generation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PastTypesId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Generation_PastTypes_PastTypesId",
                        column: x => x.PastTypesId,
                        principalTable: "PastTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RedBlue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_iId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Gray = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Gray = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedBlue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedBlue_GenerationI_Generation_iId",
                        column: x => x.Generation_iId,
                        principalTable: "GenerationI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yellow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_iId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Gray = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Gray = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yellow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yellow_GenerationI_Generation_iId",
                        column: x => x.Generation_iId,
                        principalTable: "GenerationI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Crystal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_iiId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crystal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crystal_GenerationII_Generation_iiId",
                        column: x => x.Generation_iiId,
                        principalTable: "GenerationII",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gold",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_iiId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gold", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gold_GenerationII_Generation_iiId",
                        column: x => x.Generation_iiId,
                        principalTable: "GenerationII",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Silver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_iiId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Silver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Silver_GenerationII_Generation_iiId",
                        column: x => x.Generation_iiId,
                        principalTable: "GenerationII",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emerald",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_iiiId = table.Column<int>(type: "int", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emerald", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emerald_GenerationIII_Generation_iiiId",
                        column: x => x.Generation_iiiId,
                        principalTable: "GenerationIII",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireredLeafgreen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_iiiId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireredLeafgreen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireredLeafgreen_GenerationIII_Generation_iiiId",
                        column: x => x.Generation_iiiId,
                        principalTable: "GenerationIII",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RubySapphire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_iiiId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RubySapphire", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RubySapphire_GenerationIII_Generation_iiiId",
                        column: x => x.Generation_iiiId,
                        principalTable: "GenerationIII",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiamondPearl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_ivId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiamondPearl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiamondPearl_GenerationIV_Generation_ivId",
                        column: x => x.Generation_ivId,
                        principalTable: "GenerationIV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeartgoldSoulsilver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_ivId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartgoldSoulsilver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeartgoldSoulsilver_GenerationIV_Generation_ivId",
                        column: x => x.Generation_ivId,
                        principalTable: "GenerationIV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Platinum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_ivId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platinum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Platinum_GenerationIV_Generation_ivId",
                        column: x => x.Generation_ivId,
                        principalTable: "GenerationIV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlackWhite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_vId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackWhite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlackWhite_GenerationV_Generation_vId",
                        column: x => x.Generation_vId,
                        principalTable: "GenerationV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OmegarubyAlphasapphire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_viId = table.Column<int>(type: "int", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OmegarubyAlphasapphire", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OmegarubyAlphasapphire_GenerationVI_Generation_viId",
                        column: x => x.Generation_viId,
                        principalTable: "GenerationVI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "XYs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_viId = table.Column<int>(type: "int", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XYs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XYs_GenerationVI_Generation_viId",
                        column: x => x.Generation_viId,
                        principalTable: "GenerationVI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UltraSunUltraMoon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Generation_viiId = table.Column<int>(type: "int", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UltraSunUltraMoon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UltraSunUltraMoon_GenerationVII_Generation_viiId",
                        column: x => x.Generation_viiId,
                        principalTable: "GenerationVII",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animated",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Black_WhiteId = table.Column<int>(type: "int", nullable: false),
                    Back_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Back_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Default = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Female = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Front_Shiny_Female = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animated", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animated_BlackWhite_Black_WhiteId",
                        column: x => x.Black_WhiteId,
                        principalTable: "BlackWhite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ability_AbilitiesId",
                table: "Ability",
                column: "AbilitiesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animated_Black_WhiteId",
                table: "Animated",
                column: "Black_WhiteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlackWhite_Generation_vId",
                table: "BlackWhite",
                column: "Generation_vId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Crystal_Generation_iiId",
                table: "Crystal",
                column: "Generation_iiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiamondPearl_Generation_ivId",
                table: "DiamondPearl",
                column: "Generation_ivId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DreamWorld_OtherId",
                table: "DreamWorld",
                column: "OtherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emerald_Generation_iiiId",
                table: "Emerald",
                column: "Generation_iiiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FireredLeafgreen_Generation_iiiId",
                table: "FireredLeafgreen",
                column: "Generation_iiiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Generation_PastTypesId",
                table: "Generation",
                column: "PastTypesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerationI_VersionsId",
                table: "GenerationI",
                column: "VersionsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerationII_VersionsId",
                table: "GenerationII",
                column: "VersionsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIII_VersionsId",
                table: "GenerationIII",
                column: "VersionsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerationIV_VersionsId",
                table: "GenerationIV",
                column: "VersionsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerationV_VersionsId",
                table: "GenerationV",
                column: "VersionsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVI_VersionsId",
                table: "GenerationVI",
                column: "VersionsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVII_IconsId",
                table: "GenerationVII",
                column: "IconsId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVII_VersionsId",
                table: "GenerationVII",
                column: "VersionsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVIII_IconsId",
                table: "GenerationVIII",
                column: "IconsId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationVIII_VersionsId",
                table: "GenerationVIII",
                column: "VersionsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gold_Generation_iiId",
                table: "Gold",
                column: "Generation_iiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HeartgoldSoulsilver_Generation_ivId",
                table: "HeartgoldSoulsilver",
                column: "Generation_ivId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Home_OtherId",
                table: "Home",
                column: "OtherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_Held_ItemId",
                table: "Item",
                column: "Held_ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Move_MovesId",
                table: "Move",
                column: "MovesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MoveLearnMethod_Version_Group_DetailsId",
                table: "MoveLearnMethod",
                column: "Version_Group_DetailsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OfficialArtwork_OtherId",
                table: "OfficialArtwork",
                column: "OtherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OmegarubyAlphasapphire_Generation_viId",
                table: "OmegarubyAlphasapphire",
                column: "Generation_viId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Other_SpritesId",
                table: "Other",
                column: "SpritesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PastTypes_TypesId",
                table: "PastTypes",
                column: "TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Platinum_Generation_ivId",
                table: "Platinum",
                column: "Generation_ivId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RedBlue_Generation_iId",
                table: "RedBlue",
                column: "Generation_iId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RubySapphire_Generation_iiiId",
                table: "RubySapphire",
                column: "Generation_iiiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Silver_Generation_iiId",
                table: "Silver",
                column: "Generation_iiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stat_StatsId",
                table: "Stat",
                column: "StatsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Type_TypesId",
                table: "Type",
                column: "TypesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UltraSunUltraMoon_Generation_viiId",
                table: "UltraSunUltraMoon",
                column: "Generation_viiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Version_Game_IndicesId",
                table: "Version",
                column: "Game_IndicesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VersionDetails_Held_ItemId",
                table: "VersionDetails",
                column: "Held_ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VersionDetails_VersionId",
                table: "VersionDetails",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionGroup_Version_Group_DetailsId",
                table: "VersionGroup",
                column: "Version_Group_DetailsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VersionGroupDetails_MovesId",
                table: "VersionGroupDetails",
                column: "MovesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Versions_SpritesId",
                table: "Versions",
                column: "SpritesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_XYs_Generation_viId",
                table: "XYs",
                column: "Generation_viId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yellow_Generation_iId",
                table: "Yellow",
                column: "Generation_iId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ability_Abilities_AbilitiesId",
                table: "Ability",
                column: "AbilitiesId",
                principalTable: "Abilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ability_Abilities_AbilitiesId",
                table: "Ability");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Animated");

            migrationBuilder.DropTable(
                name: "Crystal");

            migrationBuilder.DropTable(
                name: "DiamondPearl");

            migrationBuilder.DropTable(
                name: "DreamWorld");

            migrationBuilder.DropTable(
                name: "Emerald");

            migrationBuilder.DropTable(
                name: "FireredLeafgreen");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Generation");

            migrationBuilder.DropTable(
                name: "GenerationVIII");

            migrationBuilder.DropTable(
                name: "Gold");

            migrationBuilder.DropTable(
                name: "HeartgoldSoulsilver");

            migrationBuilder.DropTable(
                name: "Home");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Move");

            migrationBuilder.DropTable(
                name: "MoveLearnMethod");

            migrationBuilder.DropTable(
                name: "OfficialArtwork");

            migrationBuilder.DropTable(
                name: "OmegarubyAlphasapphire");

            migrationBuilder.DropTable(
                name: "Platinum");

            migrationBuilder.DropTable(
                name: "RedBlue");

            migrationBuilder.DropTable(
                name: "RubySapphire");

            migrationBuilder.DropTable(
                name: "Silver");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Stat");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "UltraSunUltraMoon");

            migrationBuilder.DropTable(
                name: "VersionDetails");

            migrationBuilder.DropTable(
                name: "VersionGroup");

            migrationBuilder.DropTable(
                name: "XYs");

            migrationBuilder.DropTable(
                name: "Yellow");

            migrationBuilder.DropTable(
                name: "BlackWhite");

            migrationBuilder.DropTable(
                name: "PastTypes");

            migrationBuilder.DropTable(
                name: "Other");

            migrationBuilder.DropTable(
                name: "GenerationIV");

            migrationBuilder.DropTable(
                name: "GenerationIII");

            migrationBuilder.DropTable(
                name: "GenerationII");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "GenerationVII");

            migrationBuilder.DropTable(
                name: "HeldItems");

            migrationBuilder.DropTable(
                name: "Version");

            migrationBuilder.DropTable(
                name: "VersionGroupDetails");

            migrationBuilder.DropTable(
                name: "GenerationVI");

            migrationBuilder.DropTable(
                name: "GenerationI");

            migrationBuilder.DropTable(
                name: "GenerationV");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Icons");

            migrationBuilder.DropTable(
                name: "GameIndices");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Versions");

            migrationBuilder.DropTable(
                name: "Sprites");

            migrationBuilder.DropIndex(
                name: "IX_Ability_AbilitiesId",
                table: "Ability");

            migrationBuilder.DropColumn(
                name: "Base_Experience",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Location_Area_Encounters",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "AbilitiesId",
                table: "Ability");

            migrationBuilder.CreateTable(
                name: "AbilityObj",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    PokemonId1 = table.Column<int>(type: "int", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    Slot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityObj", x => x.PokemonId);
                    table.ForeignKey(
                        name: "FK_AbilityObj_Ability_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbilityObj_Pokemons_PokemonId1",
                        column: x => x.PokemonId1,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Art",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Art", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeObj",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId1 = table.Column<int>(type: "int", nullable: false),
                    Slot = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Sprite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sprite_Art_ArtId",
                        column: x => x.ArtId,
                        principalTable: "Art",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpriteObj",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    SpriteId = table.Column<int>(type: "int", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_SpriteObj_Sprite_SpriteId",
                        column: x => x.SpriteId,
                        principalTable: "Sprite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityObj_AbilityId",
                table: "AbilityObj",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityObj_PokemonId1",
                table: "AbilityObj",
                column: "PokemonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Sprite_ArtId",
                table: "Sprite",
                column: "ArtId");

            migrationBuilder.CreateIndex(
                name: "IX_SpriteObj_SpriteId",
                table: "SpriteObj",
                column: "SpriteId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeObj_PokemonId1",
                table: "TypeObj",
                column: "PokemonId1");
        }
    }
}
