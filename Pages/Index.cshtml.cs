using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokedexRazorPages.Models;
using PokedexRazorPages.Data;
using PokedexRazorPages.Services;

namespace PokedexRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PokeApi _pokeApi;
        public List<string> PokemonNames { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public PokedexRazorPagesContext _context { get; set; }


        public IndexModel(ILogger<IndexModel> logger, PokeApi pokeApi, PokedexRazorPagesContext context)
        {
            _logger = logger;
            _pokeApi = pokeApi;
            _context = context;
        }

        public async Task OnGetAsync()
        {
            try
            {
                //PokemonNames = await _pokeApi.GetPokemonNamesList();
                //Pokemons = new List<Pokemon>();
                /*foreach (string name in PokemonNames)
                {
                    Pokemon pokemonTemp = await _pokeApi.GetPokemonData(name);
                    Pokemons.Add(pokemonTemp);
                }*/
                
                _context.Pokemons.Add(await _pokeApi.GetPokemonData("bulbasaur"));
                _context.SaveChanges();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bad request {ex}");
            }
        }
    }
}