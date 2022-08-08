using Microsoft.AspNetCore.Components;

namespace BlazorFullStackCrud.Client.Pages
{
    public partial class SuperHeros : ComponentBase
    {
        [Inject]
        public ISuperHeroService SuperHeroService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await SuperHeroService.GetSuperHeroes();
        }
    }
}