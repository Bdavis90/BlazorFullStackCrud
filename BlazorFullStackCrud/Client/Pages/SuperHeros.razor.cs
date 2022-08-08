using Microsoft.AspNetCore.Components;

namespace BlazorFullStackCrud.Client.Pages
{
    public partial class SuperHeros : ComponentBase
    {
        [Inject]
        public ISuperHeroService SuperHeroService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await SuperHeroService.GetSuperHeroesAsync();
        }

        private void ShowHero(int id)
        {
            NavigationManager.NavigateTo($"hero/{id}");
        }
    }
}