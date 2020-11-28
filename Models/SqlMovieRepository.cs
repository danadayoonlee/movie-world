using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Models
{
    public class SqlMovieRepository : IMovieRepository
    {
        private readonly MovieContext context;

        public SqlMovieRepository(MovieContext context)
        {
            this.context = context;
        }

        public Movie Add(Movie movie)
        {
            context.Movie.Add(movie);
            context.SaveChanges();
            return movie;
        }

        public Movie Delete(int id)
        {
            Movie movie = context.Movie.Find(id);
            if (movie != null)
            {
                context.Movie.Remove(movie);
                context.SaveChangesAsync();
            }
            return movie;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return context.Movie.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return context.Movie.Find(id);
        }

        public Movie Edit(int id, Movie movieChanges)
        {
            var movie = context.Movie.Attach(movieChanges);
            movie.State = EntityState.Modified;
            context.SaveChanges();
            return movieChanges;
        }
    }
}
