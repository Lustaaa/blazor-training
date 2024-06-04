using Exercice2.Models;

namespace Exercice2.Services
{
    public class MovieService
    {
        private List<Movie> Movies { get; set; } = new List<Movie>();

        internal void AddMovies(Movie movie)
        {
            Movies.Add(movie);
        }

        internal List<Movie> GetAll()
        {
            return Movies;
        }

        internal Movie GetById(int id)
        {
            return Movies.FirstOrDefault(m => m.Id == id);
        }
    }
}
