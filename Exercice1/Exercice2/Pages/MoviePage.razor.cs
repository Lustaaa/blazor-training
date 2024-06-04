using Exercice2.Models;
using Exercice2.Services;
using Microsoft.AspNetCore.Components;

namespace Exercice2.Pages
{
    public partial class MoviePage
    {
        [Inject]
        public MovieService MovieService { get; set; }

        public List<Movie> Movies { get; set; }

        public int SelectedId { get; set; }

        protected override void OnInitialized()
        {
            var movie = new Movie
            {
                Id = 1,
                Title = "MonTitre",
                AnneeDeSortie = 2024,
                Realisateur = "Wouam",
                Synopsis = "Dehors ca brule"
            };
            MovieService.AddMovies(movie);

            Movies = MovieService.GetAll();
        }

        private void DisplayDetail(int id)
        {
            SelectedId = id;
        }
    }
}
