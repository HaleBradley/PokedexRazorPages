using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokedexRazorPages.Models;
using PokedexRazorPages.Services;

namespace PokedexRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PokeApi _pokeApi;
        public List<string> PokemonNames { get; set; }
        public List<Pokemon> Pokemons { get; set; }


        public IndexModel(ILogger<IndexModel> logger, PokeApi pokeApi)
        {
            _logger = logger;
            _pokeApi = pokeApi;
        }

        public async Task OnGetAsync()
        {
            try
            {
                PokemonNames = await _pokeApi.GetPokemonNamesList();
                Pokemons = new List<Pokemon>();
                foreach (string name in PokemonNames)
                {
                    Pokemon pokemonTemp = await _pokeApi.GetPokemonData(name);
                    Pokemons.Add(pokemonTemp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bad request {ex}");
            }
        }
    }
}