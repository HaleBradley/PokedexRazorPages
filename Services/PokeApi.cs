using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using PokedexRazorPages.Data;
using PokedexRazorPages.Models;

namespace PokedexRazorPages.Services
{
    
    public class PokeApi
    {
        private readonly HttpClient _httpClient;

        public PokeApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
        }

        public async Task<Pokemon> GetPokemonData(string pokemonName)
        {
            string requestUrl = $"pokemon/{pokemonName}";
            Console.WriteLine("Request URL: " + requestUrl);

            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
            Console.WriteLine("Response Status Code: " + response.StatusCode);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonResponse);
                Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(jsonResponse); 
                Console.WriteLine("Returning obj");
                return pokemon;
            } 
            else
            {
                throw new Exception($"Failed to fecth data from PokeAPI. Status Code: {response.StatusCode}");
            }
        }
        public async Task<List<string>> GetPokemonNamesList()
        {
            string requestUrl = $"pokemon?offset=0&limit=1281";
            Console.WriteLine("Request URL: " + requestUrl);

            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
            Console.WriteLine("Response Status Code: " + response.StatusCode);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonResponse);

                PokemonListResponse listResponse = JsonConvert.DeserializeObject<PokemonListResponse>(jsonResponse);

                List<string> pokemonNames = listResponse.Results.Select(result => result.Name).ToList();

                List<Pokemon> Pokemons = new List<Pokemon>();
                foreach (string name in pokemonNames)
                {
                    Pokemon pokemonTemp = await GetPokemonData(name);
                    Pokemons.Add(pokemonTemp);
                }

                var options = new DbContextOptionsBuilder<PokedexRazorPagesContext>()
                    .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = PokedexRazorPagesContext - dd0aa542 - 2af1 - 413f - af8a - 637efbe2af6d; Trusted_Connection = True; MultipleActiveResultSets = true")
                    .Options;

                using (var context = new PokedexRazorPagesContext(options))
                {
                    foreach (Pokemon pokemon in Pokemons)
                    {
                        context.Pokemons.Add(pokemon);
                    }
                }
                

                Console.WriteLine("Returning list of names");
                return pokemonNames;
            }
            else
            {
                throw new Exception($"Failed to fetch data from PokeAPI. Status Code: {response.StatusCode}");
            }
        }
    }
}
