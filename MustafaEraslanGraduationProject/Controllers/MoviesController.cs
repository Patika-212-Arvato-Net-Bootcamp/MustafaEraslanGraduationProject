using Microsoft.AspNetCore.Mvc;
using MustafaEraslanGraduationProject.Entities;
using MustafaEraslanGraduationProject.Service;

namespace MustafaEraslanGraduationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public Mytable GetMovieDetail(long id)
        {
            return _movieService.GetMovieDetail(id);
        }

        // GET api/<Movies>/5
        [HttpGet("{id}")]
        public List<Mytable> GetMovieList(int genreId)
        {
            return _movieService.GetMovieList(genreId);
        }

        [HttpGet]
        public List<Mytable> GetMovieList(float rateFilter)
        {
            return _movieService.GetMovieList(rateFilter);
        }

        [HttpGet]
        public List<Mytable> GetMovieList(DateTime releaseDate)
        {
            return _movieService.GetMovieList(releaseDate);
        }

        [HttpGet]
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
