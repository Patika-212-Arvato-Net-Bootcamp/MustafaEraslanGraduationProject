using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MustafaEraslanGraduationProject.Entities;
using MustafaEraslanGraduationProject.Service;

namespace MustafaEraslanGraduationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] 
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetMovieDetail")]
        [AllowAnonymous]
        public Mytable GetMovieDetail(long id)
        {
            return _movieService.GetMovieDetail(id);
        }

        // GET api/<Movies>/5
        [HttpGet("GetMovieListGenre")]
        [AllowAnonymous]
        public List<Mytable> GetMovieList(int genreId)
        {
            return _movieService.GetMovieList(genreId);
        }

        [HttpGet("GetMovieListRate")]
        [AllowAnonymous]
        public List<Mytable> GetMovieList(decimal rateFilter)
        {
            return _movieService.GetMovieList(rateFilter);
        }

        [HttpGet("GetMovieListRelease")]
        [AllowAnonymous]
        public List<Mytable> GetMovieList(string releaseDate)
        {
            return _movieService.GetMovieList(releaseDate);
        }

        [HttpGet("Search")]
        [AllowAnonymous]
        public List<Mytable> Search(string title)
        {
            return _movieService.Search(title);
        }

        // POST api/<Movies>
        [HttpPost]
        public void AddMovie([FromBody] Mytable mytable)
        {
            _movieService.AddMovie(mytable);
        }

        // PUT api/<Movies>/5
        [HttpPut("{id}")]
        public void UpdateMovie(long id, [FromBody] Mytable mytable)
        {
            _movieService.UpdateMovie(id,mytable);
        }

        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void DeleteMovie(long id)
        {
            _movieService.DeleteMovie(id);
        }
    }
}
