using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokedexRazorPages.Models;

namespace PokedexRazorPages.Data
{
    public class PokedexRazorPagesContext : DbContext
    {
        public PokedexRazorPagesContext (DbContextOptions<PokedexRazorPagesContext> options)
            : base(options)
        {
        }

        //public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Abilities> Abilities { get; set; }
        public DbSet<Ability> Ability { get; set; }
        public DbSet<Forms> Forms { get; set; }
        public DbSet<Game_Indices> GameIndices { get; set; }
        public DbSet<Models.Version> Version { get; set; }
        public DbSet<Held_Items> HeldItems { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Version_Details> VersionDetails { get; set; }
        public DbSet<Moves> Moves { get; set; }
        public DbSet<Move> Move { get; set; }
        public DbSet<Version_Group_Details> VersionGroupDetails { get; set; }
        public DbSet<Version_Group> VersionGroup { get; set; }
        public DbSet<Move_Learn_Method> MoveLearnMethod { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Sprites> Sprites { get; set; }
        public DbSet<Other> Other { get; set; }
        public DbSet<DreamWorld> DreamWorld { get; set; }
        public DbSet<Home> Home { get; set; }
        public DbSet<Official_Artwork> OfficialArtwork { get; set; }
        public DbSet<Versions> Versions { get; set; }

        public DbSet<Generation_i> GenerationI { get; set; }
        public DbSet<Red_Blue> RedBlue { get; set; }
        public DbSet<Yellow> Yellow { get; set; }

        public DbSet<Generation_ii> GenerationII { get; set; }
        public DbSet<Crystal> Crystal { get; set; }
        public DbSet<Gold> Gold { get; set; }
        public DbSet<Silver> Silver { get; set; }

        public DbSet<Generation_iii> GenerationIII { get; set; }
        public DbSet<Emerald> Emerald { get; set; }
        public DbSet<Firered_Leafgreen> FireredLeafgreen { get; set; }
        public DbSet<Ruby_Sapphire> RubySapphire { get; set; }

        public DbSet<Generation_iv> GenerationIV { get; set; }
        public DbSet<Diamond_Pearl> DiamondPearl { get; set; }
        public DbSet<Heartgold_Soulsilver> HeartgoldSoulsilver { get; set; }
        public DbSet<Platinum> Platinum { get; set; }

        public DbSet<Generation_v> GenerationV { get; set; }
        public DbSet<Black_White> BlackWhite { get; set; }
        public DbSet<Animated> Animated { get; set; }

        public DbSet<Generation_vi> GenerationVI { get; set; }
        public DbSet<Omegaruby_Alphasapphire> OmegarubyAlphasapphire { get; set; }
        public DbSet<X_Y> XYs { get; set; }

        public DbSet<Generation_vii> GenerationVII { get; set; }
        public DbSet<Icons_vii> Icons_vii { get; set; }
        public DbSet<Ultra_Sun_Ultra_Moon> UltraSunUltraMoon { get; set; }

        public DbSet<Generation_viii> GenerationVIII { get; set; }
        public DbSet<Icons_viii> Icons_viii { get; set; }

        public DbSet<Stats> Stats { get; set; }
        public DbSet<Stat> Stat { get; set; }

        public DbSet<Types> Types { get; set; }
        public DbSet<Models.Type> Type { get; set; }

        public DbSet<PastTypes> PastTypes { get; set; }
        public DbSet<Generation> Generation { get; set; }

        public DbSet<PokedexRazorPages.Models.Rating> Rating { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Abilities>()
                .HasMany(e => e.Abilitys)
                .WithOne(e => e.Abilities)
                .HasForeignKey(e => e.AbilitiesId)
                .IsRequired();
        }
    }
}
