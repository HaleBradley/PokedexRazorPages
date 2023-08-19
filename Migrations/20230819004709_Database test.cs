using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokedexRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class Databasetest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpriteId",
                table: "SpriteObj",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AbilityId",
                table: "AbilityObj",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_SpriteObj_SpriteId",
                table: "SpriteObj",
                column: "SpriteId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityObj_AbilityId",
                table: "AbilityObj",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprite_ArtId",
                table: "Sprite",
                column: "ArtId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbilityObj_Ability_AbilityId",
                table: "AbilityObj",
                column: "AbilityId",
                principalTable: "Ability",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpriteObj_Sprite_SpriteId",
                table: "SpriteObj",
                column: "SpriteId",
                principalTable: "Sprite",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbilityObj_Ability_AbilityId",
                table: "AbilityObj");

            migrationBuilder.DropForeignKey(
                name: "FK_SpriteObj_Sprite_SpriteId",
                table: "SpriteObj");

            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "Sprite");

            migrationBuilder.DropTable(
                name: "Art");

            migrationBuilder.DropIndex(
                name: "IX_SpriteObj_SpriteId",
                table: "SpriteObj");

            migrationBuilder.DropIndex(
                name: "IX_AbilityObj_AbilityId",
                table: "AbilityObj");

            migrationBuilder.DropColumn(
                name: "SpriteId",
                table: "SpriteObj");

            migrationBuilder.DropColumn(
                name: "AbilityId",
                table: "AbilityObj");
        }
    }
}
