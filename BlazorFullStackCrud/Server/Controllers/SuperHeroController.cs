//using BlazorFullStackCrud.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFullStackCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public static List<Comic> Comics = new List<Comic>
        {
            new Comic { Id = 1, Name = "Marvel"},
            new Comic { Id = 2, Name = "DC"}
        };

        public static List<SuperHero> SuperHeroes = new List<SuperHero>
        {
            new SuperHero{
                Id = 1,
                FirstName = "Peter",
                LastName = "Parker",
                HeroName = "Spiderman",
                Comic = Comics[0],
                ComicId = 1,
            },
            new SuperHero{
                Id = 2,
                FirstName = "Bruce",
                LastName = "Wayne",
                HeroName = "Batman",
                Comic = Comics[1],
                ComicId = 2
            }

        };

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeros()
        {
            return Ok(SuperHeroes);
        }

        [HttpGet("comics")]
        public async Task<ActionResult<List<Comic>>> GetComics()
        {
            return Ok(Comics);
        }

        [HttpGet("{id}")]
        //[Route("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHeros(int id)
        {
            var hero = SuperHeroes.FirstOrDefault(x => x.Id == id);
            if (hero is null)
            {
                return NotFound("Sorry, no hero here. :/");
            }
            return Ok(hero);
        }
    }
}
