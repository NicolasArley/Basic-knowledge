using Business.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Business.PokeApi
{
    public class PokeApi
    {
       
        public static async Task<List<string>> GetPokemon(string color)
        { 
            List<string> pokename = new List<string>();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://pokeapi.co/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/v2/pokemon-color/" + color);

                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    JObject responseJson = await response.Content.ReadAsAsync<JObject>();
                    Root pokemodel = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(responseJson.ToString());

                    foreach (PokemonSpecy pokemonSpecy in pokemodel.pokemon_species)
                    {
                        pokename.Add(pokemonSpecy.name);
                    }
                }
                else
                {
                    Console.WriteLine("{0} ({1})",(int)response.StatusCode, response.ReasonPhrase);
                }
            }
            return pokename;
        }

    }
    
}
