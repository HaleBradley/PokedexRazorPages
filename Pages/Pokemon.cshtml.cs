using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PokedexRazorPages.Pages
{
    public class PokemonModel : PageModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Height { get; set; }
        public string Category { get; set; }
        public double Weight { get; set; }
        public string[] Abilities { get; set; }
        public string Gender { get; set; }
        public string[] Types { get; set; }
        public string[] Weaknesses { get; set; }

        public void OnGet(string? mon)
        {
            Name = "Bulbasaur";
            Id = 0001;
            Image = "~/images/bulbasaur.png";
            Description = "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.";
            Height = "2'04\"";
            Category = "Seed";
            Weight = 15.2;
            Abilities = new string[] { "Overgrow" };
            Gender = "♂ ♀";
            Types = new string[] { "Grass", "Poison" };
            Weaknesses = new string[] {"Fire", "Psychic", "Flying", "Ice"};
        }
    }
}
