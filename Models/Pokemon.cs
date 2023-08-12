using Microsoft.CodeAnalysis.Classification;
using Microsoft.CodeAnalysis.Operations;
using Newtonsoft.Json;

namespace PokedexRazorPages.Models
{
    public class Pokemon
    {
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


        public class AbilityObj
        {
            public Ability Ability { get; set; }
            public bool IsHidden { get; set; }
            public int Slot { get; set; }
        }

        public class Ability
        {
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class SpriteObj
        {
            [JsonProperty("other")]
            public Sprite Sprite { get; set; }
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
            public Type Type { get; set; } 
        }

        public class Type
        {
            public string Name { get; set; }
            public string Url { get; set; }
        }
    }
}
