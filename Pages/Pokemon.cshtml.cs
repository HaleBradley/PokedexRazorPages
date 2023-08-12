using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Elfie.Extensions;
using PokedexRazorPages.Models;
using PokedexRazorPages.Services;
using static PokedexRazorPages.Models.Pokemon;

namespace PokedexRazorPages.Pages
{
    public class PokemonModel : PageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<string> Abilities { get; set; }
        public string Image { get; set; }
        public List<string> Types { get; set; }
        public string Api { get; set; }

        private readonly PokeApi _pokeApi;

        public PokemonModel(PokeApi pokeApi)
        {
            _pokeApi = pokeApi;
        }

        public async Task OnGetAsync(string? name)
        {
            if (name != null)
            {
                try
                {
                    Pokemon pokemonData = await _pokeApi.GetPokemonData(name);
                    Id = pokemonData.Id;
                    Name = pokemonData.Name;
                    Height = pokemonData.Height;
                    Weight = pokemonData.Weight;
                    Abilities = new List<string>();
                    foreach (var abilityObj in pokemonData.Abilities)
                    {
                        Abilities.Add(abilityObj.Ability.Name);
                    }
                    Image = pokemonData.Sprites.Sprite.Art.Image;
                    Types = new List<string>();
                    foreach (var typeObj in pokemonData.Types)
                    {
                        Types.Add(typeObj.Type.Name);
                    }
                }
                catch (Exception ex)
                {
                    Api = "Bad Request";
                }
            }
        }
    }
}
