using Exercice2.Models;
using Exercice2.Services;
using Microsoft.AspNetCore.Components;

namespace Exercice2.Pages
{
    public partial class DetailMovie
    {
        [Inject]
        public MovieService MovieService { get; set; }

        [Parameter]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public bool Default { get; set; }

        protected override void OnInitialized()
        {
            MovieId = 0;
        }

        protected override void OnParametersSet()
        {
            if (MovieId != 0)
                Movie = MovieService.GetById(MovieId);
            else
                Movie = new Movie();
        }
    }
}
