using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
        //TODO: Get every pokemon not just first 20 (20 sent for each request)
        public async Task<List<string>> GetPokemonNamesList()
        {
            string requestUrl = $"pokemon";
            Console.WriteLine("Request URL: " + requestUrl);

            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
            Console.WriteLine("Response Status Code: " + response.StatusCode);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonResponse);

                PokemonListResponse listResponse = JsonConvert.DeserializeObject<PokemonListResponse>(jsonResponse);

                List<string> pokemonNames = listResponse.Results.Select(result => result.Name).ToList();

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
