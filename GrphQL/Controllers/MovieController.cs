using GrphQL.IRepository;
using GrphQL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrphQL.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepo;

        public MovieController(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }

        [HttpGet]
        [Route("api/movies")]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _movieRepo.GetMovies();

            return Ok(movies);
        }

        [HttpGet]
        [Route("api/movies/{id}")]
        public async Task<IActionResult> GetMovie(Guid id)
        {
            var movie = await _movieRepo.GetMovie(id);
            return Ok(movie);
        }

        [HttpPost]
        [Route("api/movies")]
        public async Task<IActionResult> AddMovie([FromBody] Movie movie)
        {
            await _movieRepo.AddMovie(movie);
            return Ok();
        }

        [HttpPut]
        [Route("api/movies")]
        public async Task<IActionResult> UpdateMovie([FromBody] Movie movie)
        {
            var Movie = await _movieRepo.UpdateMovie(movie);


            await _movieRepo.UpdateMovie(movie);
            return Ok();
        }

    }
}
