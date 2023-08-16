using Microsoft.CodeAnalysis.Classification;
using Microsoft.CodeAnalysis.Operations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokedexRazorPages.Models
{
    public partial class Pokemon
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
        [NotMapped]
        public Ability Ability { get; set; }
        public bool IsHidden { get; set; }
        public int Slot { get; set; }

        [Key]
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
    }

    public class Ability
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class SpriteObj
    {
        [NotMapped]
        [JsonProperty("other")]
        public Sprite Sprite { get; set; }

        [Key]
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
    }

    public class Sprite
    {
        [JsonProperty("official-artwork")]
        public Art Art { get; set; }

    }

    public class Art
    {
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
    }
}
