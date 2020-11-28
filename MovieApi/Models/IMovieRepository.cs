using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Models
{
    public interface IMovieRepository
    {
        Movie GetMovieById(int id);
        IEnumerable<Movie> GetAllMovies();
        Movie Add(Movie movie);
        Movie Edit(int id, Movie movieChanges);
        Movie Delete(int id);
    }
}
