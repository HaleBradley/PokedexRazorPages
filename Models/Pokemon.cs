using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Classification;
using Microsoft.CodeAnalysis.Operations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokedexRazorPages.Models
{
    /*public partial class Pokemon
    {
        //TODO: Rework database to hole each pokemons info accurately and useable by page models.

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("weight")]
        public int Weight { get; set; }
        [JsonProperty("abilities")]
        public List<AbilityObj> Abilities { get; set; }
        [JsonProperty("sprites")]
        public SpriteObj Sprites { get; set; }
        [JsonProperty("types")]
        public List<TypeObj> Types { get; set; }
    }



    public class AbilityObj
    {
        public int AbilityId { get; set; }
        public Ability Ability { get; set; }
        public bool IsHidden { get; set; }
        public int Slot { get; set; }

        [Key]
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
    }

    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class SpriteObj
    {
        [JsonProperty("other")]
        public Sprite Sprite { get; set; }

        [Key]
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
    }

    public class Sprite
    {
        public int Id { get; set; }
        [JsonProperty("official-artwork")]
        public Art Art { get; set; }

    }

    public class Art
    {
        public int Id { get; set; }
        [JsonProperty("front_default")]
        public string Image { get; set; }
    }

    public class TypeObj
    {
        public int Slot { get; set; }
        [NotMapped]
        public Type Type { get; set; }

        [Key]
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
    }

    public class Type
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }*/

    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Base_Experience { get; set; }
        public int Height { get; set; }
        public bool IsDefault { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public string Location_Area_Encounters { get; set; }

        public ICollection<Abilities> Abilities { get; set; }
        public ICollection<Forms> Forms { get; set; }
        public ICollection<Game_Indices> Game_Indices { get; set; }
        public ICollection<Held_Items> Held_Items { get; set; }
        public ICollection<Moves> Moves { get; set; }
        public Species Species { get; set; }
        public Sprites Sprites { get; set; }
        public ICollection<Stats> Stats { get; set; }
        public ICollection<Types> Types { get; set; }
        public ICollection<PastTypes> PastTypes { get; set; }

    }

    public class Abilities
    {
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public bool Is_Hidden { get; set; }
        public int Slot { get; set; }

        public ICollection<Ability> Abilitys { get; set; } = new List<Ability>();
    }

    public class Ability
    {
        public int Id { get; set; }
        public int AbilitiesId { get; set; }
        public virtual Abilities Abilities { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Forms
    {
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }


    public class Game_Indices
    {
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public int Game_Index { get; set; }
        public Version Version { get; set; }
    }

    public class Version
    {
        public int Id { get; set; }
        public int Game_IndicesId { get; set; }
        public Game_Indices Game_Indices { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
    
    public class Held_Items
    {
        public int Id { get; set; }
        public Pokemon Pokemon { get; set; }
        public Item Item { get; set; }
        public ICollection<Version_Details> Version_Details { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public Held_Items Held_Items { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Version_Details
    {
        public int Id { get; set; }
        public Held_Items Held_Items { get; set; }
        public int Rarity { get; set; }
        public ItemVersion ItemVersion { get; set; }
    }

    public class ItemVersion
    {
        public int Id { get; set; }
        public Version_Details Version_Details { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Moves
    {
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Move Move { get; set; }
        public ICollection<Version_Group_Details> Version_Group_Details { get; set; }
    }

    public class Move
    {
        public int Id { get; set; }
        public Moves Moves { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Version_Group_Details
    {
        public int Id { get; set; }
        public Moves Moves { get; set; }
        public string Level_Learned_At { get; set; }
        public Version_Group Version_Group { get; set; }
        public Move_Learn_Method Move_Learn_Method { get; set; }
    }

    public class Version_Group
    {
        public int Id { get; set; }
        public Version_Group_Details Version_Group_Details { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Move_Learn_Method
    {
        public int Id { get; set; }
        public Version_Group_Details Version_Group_Details { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Species
    {
        public int Id { get; set; }
        public Pokemon Pokemon { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Sprites
    {
        public int Id { get; set; }
        public Pokemon Pokemon { get; set; }
        public string Back_Default { get; set; }
        public string Back_Female { get; set; }
        public string Back_Shiny { get; set; }
        public string Back_Shiny_Female { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
        public string Front_Shiny { get; set; }
        public string Front_Shiny_Female { get; set; }
        public Other Other { get; set; }
        public Versions Versions { get; set; }
    }

    public class Other
    {
        public int Id { get; set; }
        public Sprites Sprites { get; set; }
        public DreamWorld DreamWorld { get; set; }
        public Home Home { get; set; }
        public Official_Artwork Official_Artwork { get; set; }
    }

    public class DreamWorld
    {
        public int Id { get; set; }
        public Other Other { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
    }

    public class Home
    {
        public int Id { get; set; }
        public Other Other { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
        public string Front_Shiny { get; set; }
        public string Front_Shiny_Female { get; set; }
    }

    public class Official_Artwork 
    {
        public int Id { get; set; }
        public Other Other { get; set; }
        public string Front_Default { get; set; }
    }

    public class Versions
    {
        public int Id { get; set; }
        public Sprites Sprites { get; set; }
        public Generation_i Generation_i { get; set; }
        public Generation_ii Generation_ii { get; set; }
        public Generation_iii Generation_iii { get; set; }
        public Generation_iv Generation_iv { get; set; }
        public Generation_v Generation_v { get; set; }
        public Generation_vi Generation_vi { get; set; }
        public Generation_vii Generation_vii { get; set; }
        public Generation_viii Generation_viii { get; set; }
    }

    public class Generation_i 
    {
        public int Id { get; set; }
        public Versions Versions { get; set; }
        public Red_Blue Red_Blue { get; set; }
        public Yellow Yellow { get; set; }
    }

    public class Red_Blue 
    {
        public int Id { get; set; }
        public Generation_i Generation_i { get; set; }
        public string Back_Default { get; set; }
        public string Back_Gray { get; set; }
        public string Front_Default { get; set; }
        public string Front_Gray { get; set; }
    }

    public class Yellow 
    {
        public int Id { get; set; }
        public Generation_i Generation_i { get; set; }
        public string Back_Default { get; set; }
        public string Back_Gray { get; set; }
        public string Front_Default { get; set; }
        public string Front_Gray { get; set; }
    }

    public class Generation_ii
    {
        public int Id { get; set; }
        public Versions Versions { get; set; }
        public Crystal Crystal { get; set; }
        public Gold Gold { get; set; }
        public Silver Silver { get; set; }
    }

    public class Crystal
    {
        public int Id { get; set; }
        public Generation_ii Generation_ii { get; set; }
        public string Back_Default { get; set; }
        public string Back_Shiny { get; set; }
        public string Front_Default { get; set; }
        public string Front_Shiny { get; set; }
    }

    public class Gold
    {
        public int Id { get; set; }
        public Generation_ii Generation_ii { get; set; }
        public string Back_Default { get; set; }
        public string Back_Shiny { get; set; }
        public string Front_Default { get; set; }
        public string Front_Shiny { get; set; }
    }

    public class Silver
    {
        public int Id { get; set; }
        public Generation_ii Generation_ii { get; set; }
        public string Back_Default { get; set; }
        public string Back_Shiny { get; set; }
        public string Front_Default { get; set; }
        public string Front_Shiny { get; set; }
    }

    public class Generation_iii
    {
        public int Id { get; set; }
        public Versions Versions { get; set; }
        public Emerald Emerald { get; set; }
        public Firered_Leafgreen Firered_Leafgreen { get; set; }
        public Ruby_Sapphire Ruby_Sapphire { get; set; }
    }

    public class Emerald
    {
        public int Id { get; set; }
        public Generation_iii Generation_iii { get; set; }
        public string Front_Default { get; set; }
        public string Front_Shiny { get; set; }
    }

    public class Firered_Leafgreen
    {
        public int Id { get; set; }
        public Generation_iii Generation_iii { get; set; }
        public string Back_Default { get; set; }
        public string Back_Shiny { get; set; }
        public string Front_Default { get; set; }
        public string Front_Shiny { get; set; }
    }

    public class Ruby_Sapphire
    {
        public int Id { get; set; }
        public Generation_iii Generation_iii { get; set; }
        public string Back_Default { get; set; }
        public string Back_Shiny { get; set; }
        public string Front_Default { get; set; }
        public string Front_Shiny { get; set; }
    }

    public class Generation_iv
    {
        public int Id { get; set; }
        public Versions Versions { get; set; }
        public Diamond_Pearl Diamond_Pearl { get; set; }
        public Heartgold_Soulsilver Heartgold_Soulsilver { get; set; }
        public Platinum Platinum { get; set; }
    }

    public class Diamond_Pearl
    {
        public int Id { get; set; }
        public Generation_iv Generation_iv { get; set; }
        public string Back_Default { get; set; }
        public string Back_Female { get; set; }
        public string Back_Shiny { get; set; }
        public string Back_Shiny_Female { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
        public string Front_Shiny { get; set; }
        public string Front_Shiny_Female { get; set; }
    }

    public class Heartgold_Soulsilver
    {
        public int Id { get; set; }
        public Generation_iv Generation_iv { get; set; }
        public string Back_Default { get; set; }
        public string Back_Female { get; set; }
        public string Back_Shiny { get; set; }
        public string Back_Shiny_Female { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
        public string Front_Shiny { get; set; }
        public string Front_Shiny_Female { get; set; }
    }

    public class Platinum
    {
        public int Id { get; set; }
        public Generation_iv Generation_iv { get; set; }
        public string Back_Default { get; set; }
        public string Back_Female { get; set; }
        public string Back_Shiny { get; set; }
        public string Back_Shiny_Female { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
        public string Front_Shiny { get; set; }
        public string Front_Shiny_Female { get; set; }
    }

    public class Generation_v
    {
        public int Id { get; set; }
        public Versions Versions { get; set; }
        public Black_White Black_White { get; set; }
    }
    //TODO KEEP CONNECTIONG TABLES
    public class Black_White
    {
        public int Id { get; set; }
        public int Generation_vId { get; set; }
        public Generation_v Generation_v { get; set; }
        public Animated Animated { get; set; }
        public string Back_Default { get; set; }
        public string Back_Female { get; set; }
        public string Back_Shiny { get; set; }
        public string Back_Shiny_Female { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
        public string Front_Shiny { get; set; }
        public string Front_Shiny_Female { get; set; }
    }

    public class Animated
    {
        public int Id { get; set; }
        public int Black_WhiteId { get; set; }
        public Black_White Black_White { get; set; }
        public string Back_Default { get; set; }
        public string Back_Female { get; set; }
        public string Back_Shiny { get; set; }
        public string Back_Shiny_Female { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
        public string Front_Shiny { get; set; }
        public string Front_Shiny_Female { get; set; }
    }

    public class Generation_vi
    {
        public int Id { get; set; }
        public int VersionsId { get; set; }
        public Versions Versions { get; set; }
        public Omegaruby_Alphasapphire Omegaruby_Alphasapphire { get; set; }
        public X_Y X_Y { get; set; }
    }

    public class Omegaruby_Alphasapphire
    {
        public int Id { get; set; }
        public int Generation_viId { get; set; }
        public Generation_vi Generation_vi { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
        public string Front_Shiny { get; set; }
        public string Front_Shiny_Female { get; set; }
    }
    public class X_Y
    {
        public int Id { get; set; }
        public int Generation_viId { get; set; }
        public Generation_vi Generation_vi { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
        public string Front_Shiny { get; set; }
        public string Front_Shiny_Female { get; set; }
    }

    public class Generation_vii
    {
        public int Id { get; set; }
        public int VersionsId { get; set; }
        public Versions Versions { get; set; }
        public Icons_vii Icons_vii { get; set; }
        public Ultra_Sun_Ultra_Moon Ultra_Sun_Ultra_Moon { get; set; }
    }

    public class Icons_vii
    {
        public int Id { get; set; }
        public int Generation_viiId { get; set; }
        public Generation_vii Generation_vii { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
    }

    public class Ultra_Sun_Ultra_Moon
    {
        public int Id { get; set; }
        public int Generation_viiId { get; set; }
        public Generation_vii Generation_vii { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
        public string Front_Shiny { get; set; }
        public string Front_Shiny_Female { get; set; }
    }

    public class Generation_viii
    {
        public int Id { get; set; }
        public int VersionsId { get; set; }
        public Versions Versions { get; set; }
        public Icons_viii Icons_viii { get; set; }
    }

    public class Icons_viii
    {
        public int Id { get; set; }
        public int Generation_viiiId { get; set; }
        public Generation_viii Generation_viii { get; set; }
        public string Front_Default { get; set; }
        public string Front_Female { get; set; }
    }

    public class Stats
    {
        public int Id { get; set; }
        public int PokemondId { get; set; }
        public Pokemon Pokemon { get; set; }
        public int Base_Stat { get; set; }
        public int Effort { get; set; }
        public Stat Stat { get; set; }
    }

    public class Stat 
    {
        public int Id { get; set; }
        public int StatsId { get; set; }
        public Stats Stats { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Types
    {
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public int Slot { get; set; }
        public Type Type { get; set; }
    }

    public class Type
    {
        public int Id { get; set; }
        public int TypesId { get; set; }
        public Types Types { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
    
    public class PastTypes
    {
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Generation Generation { get; set; }
        public Types Types { get; set; }
    }

    public class Generation
    {
        public int Id { get; set; }
        public int PastTypesId { get; set; }
        public PastTypes PastTypes { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
    //Add-Migration
}