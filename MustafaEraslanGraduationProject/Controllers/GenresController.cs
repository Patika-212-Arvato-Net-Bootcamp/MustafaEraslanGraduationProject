using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MustafaEraslanGraduationProject.Entities;
using MustafaEraslanGraduationProject.Service;

namespace MustafaEraslanGraduationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GenresController : ControllerBase
    {
        private IGenreService _genreService;
        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        // GET: api/<GenresController>
        [HttpGet]
        [AllowAnonymous]
        public List<Genres> ListGenres(long movieId)
        {
            return _genreService.ListGenres(movieId);
        }


        // POST api/<GenresController>
        [HttpPost]
        public void AddGenre(long movieId, [FromBody]  Genres genre)
        {
            _genreService.AddGenre(movieId, genre);
            //string yerine Genre entities oluşturulacak. O nesne buraya verilecek.
        }

        // PUT api/<GenresController>/5
        [HttpPut("{movieId}")]
        public void UpdateGenre(long movieId,int genreId, [FromBody] Genres genre)
        {
            _genreService.UpdateGenre(movieId,genreId,genre);
            //string yerine Genre entities oluşturulacak. O nesne buraya verilecek.value değerleriküçük.
        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{movieId}")]
        public void DeleteGenre(long movieId, int genreId)
        {
            _genreService.DeleteGenre(movieId,genreId); 
        }
    }
}