using Exercice2.Models;
using Exercice2.Services;
using Microsoft.AspNetCore.Components;

namespace Exercice2.Pages
{
    public partial class AddMovie
    {
        [Inject]
        public MovieService MovieService { get; set; }

        [Parameter]
        public EventCallback NeedToRefreshParent { get; set; }

        public Movie NewMovie { get; set; }

        protected override void OnInitialized()
        {
            NewMovie = new Movie();
        }

        public void OnValidSubmit()
        {
            Console.WriteLine("Formulaire OK");
            MovieService.AddMovies(NewMovie);
            NeedToRefreshParent.InvokeAsync();
            StateHasChanged();
        }
    }
}
