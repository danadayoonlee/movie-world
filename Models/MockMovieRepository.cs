using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Models
{
    public class MockMovieRepository
    {
        private List<Movie> _movieList;

        public MockMovieRepository()
        {
            _movieList = new List<Movie>()
            {
                new Movie() {
                    Id = 1,
                    Title = "Get Out",
                    Description = "A young African American man visits his European American girlfriend's family estate where he learns that many of its residents, who are black, have gone missing, and he soon learns the horrible truth when another frantic African-American warns him to \"get out\". He soon learns this is easier said than done.",
                    DateReleased = DateTime.Parse("2017-2-24"),
                    Genre = "Horror, Mystery",
                    Actor = "Daniel Kaluuya, Allison Williams, Bradley Whitford",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTE2Nzg1NjkzNV5BMl5BanBnXkFtZTgwOTgyODMyMTI@._V1_SY500_CR0,0,315,500_AL_.jpg"
                }
            };
        }

        public Movie Add(Movie movie)
        {
            movie.Id = _movieList.Max(m => m.Id) + 1;
            _movieList.Add(movie);
            return movie;
        }

        public Movie Delete(int id)
        {
            Movie movie = _movieList.FirstOrDefault(m => m.Id == id);
            if (movie != null)
            {
                _movieList.Remove(movie);
            }
            return movie;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _movieList;
        }

        public Movie GetMovie(int id)
        {
            return _movieList.FirstOrDefault(m => m.Id == id);
        }

        public Movie Edit(Movie movieChanges)
        {
            Movie movie = _movieList.FirstOrDefault(m => m.Id == movieChanges.Id);
            if (movie != null)
            {
                movie.Title = movieChanges.Title;
                movie.Description = movieChanges.Description;
                movie.DateReleased = movieChanges.DateReleased;
                movie.Genre = movieChanges.Genre;
                movie.Actor = movieChanges.Actor;
                movie.ImageUrl = movieChanges.ImageUrl;
            }
            return movie;
        }
    }
}
