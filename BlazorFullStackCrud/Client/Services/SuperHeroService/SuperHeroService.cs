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



        public Task GetComics()
        {
            throw new NotImplementedException();
        }

        public async Task<SuperHero> GetSingleHero(int id)
        {
            var results = await http.GetFromJsonAsync<SuperHero>($"api/superhero/{id}");

            return results;

        }

        public async Task GetSuperHeroes()
        {
            var results = await http.GetFromJsonAsync<List<SuperHero>>("api/superhero");
            if (results is not null)
                Heros = results;
        }
    }
}
