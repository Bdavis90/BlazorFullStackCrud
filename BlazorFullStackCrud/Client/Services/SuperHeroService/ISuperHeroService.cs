namespace BlazorFullStackCrud.Client.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> Heros { get; set; }
        List<Comic> Comics { get; set; }
        Task GetComicsAsync();
        Task GetSuperHeroesAsync();
        Task<SuperHero> GetSingleHeroAsync(int? id);
    }
}
