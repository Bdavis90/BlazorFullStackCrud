using Microsoft.AspNetCore.Components;

namespace BlazorFullStackCrud.Client.Pages
{
    public partial class Hero
    {
        [Inject]
        public ISuperHeroService SuperHeroService { get; set; }

        [Parameter]
        public int? Id { get; set; }
        private SuperHero hero = new SuperHero { Comic = new Comic() };
        private string btnText = string.Empty;
        protected override async Task OnInitializedAsync()
        {
            btnText = Id is null ? "Save New Hero" : "Update Hero";
            await SuperHeroService.GetComicsAsync();
        }
        protected async override Task OnParametersSetAsync()
        {
            if (Id is null)
            {
                //Create new Hero
            }
            {
                hero = await SuperHeroService.GetSingleHeroAsync(Id);
            }
        }

        private async Task HandleSubmit()
        {

        }
    }
}
