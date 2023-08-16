using Newtonsoft.Json;

namespace PokedexRazorPages.Models
{
    public class PokemonListResponse
    {
        [JsonProperty("results")]
        public List<PokemonResult> Results { get; set; }
        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class PokemonResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

}
