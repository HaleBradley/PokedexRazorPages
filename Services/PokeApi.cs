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
    }
}
