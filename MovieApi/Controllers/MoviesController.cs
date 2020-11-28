using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApi.Models;
using AutoMapper;

namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MoviesController(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        #region GetAll
        // GET: api/Movies
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetAllMovie()
        {
            var movies = _movieRepository.GetAllMovies();
            var movieViewModel = _mapper.Map<IEnumerable<MovieViewModel>>(movies);
            return Ok(movieViewModel);
        }
        #endregion

        #region GetByID
        // GET: api/Movies/5
        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            var movie = _movieRepository.GetMovieById(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }
        #endregion

        #region Put_Edit
        // PUT: api/Movies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public ActionResult PutMovie(int id, Movie movie)
        {
            return Ok(_movieRepository.Edit(id, movie));
        }
        #endregion

        #region Post_Create
        // POST: api/Movies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            return Ok(_movieRepository.Add(movie));
        }
        #endregion

        #region Delete
        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public ActionResult<Movie> DeleteMovie(int id)
        {
            return Ok(_movieRepository.Delete(id));
        }
        #endregion
    }
}
