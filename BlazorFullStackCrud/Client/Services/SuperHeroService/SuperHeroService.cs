using System.Net.Http.Json;

namespace BlazorFullStackCrud.Client.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly HttpClient http;

        public SuperHeroService(HttpClient http)
        {
            this.http = http;
        }

        public List<SuperHero> Heros { get; set; } = new List<SuperHero>();
        public List<Comic> Comics { get; set; } = new List<Comic>();



        public async Task GetComicsAsync()
        {
            var results = await http.GetFromJsonAsync<List<Comic>>("api/superhero/comics");
            if (results is not null)
                Comics = results;
        }

        public async Task<SuperHero> GetSingleHeroAsync(int? id)
        {
            var result = await http.GetFromJsonAsync<SuperHero>($"api/superhero/{id}");

            return await Task.FromResult(result);

        }

        public async Task GetSuperHeroesAsync()
        {
            var results = await http.GetFromJsonAsync<List<SuperHero>>("api/superhero");
            if (results is not null)
                Heros = results;
        }
    }
}
