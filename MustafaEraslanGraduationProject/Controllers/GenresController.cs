using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MustafaEraslanGraduationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        // GET: api/<GenresController>
        [HttpGet]
        public IEnumerable<string> ListGenres()
        {
            return new string[] { "value1", "value2" };
        }


        // POST api/<GenresController>
        [HttpPost]
        public void AddGenre([FromBody] string genre)
        {
            //string yerine Genre entities oluşturulacak. O nesne buraya verilecek.
        }

        // PUT api/<GenresController>/5
        [HttpPut("{id}")]
        public void UpdateGenre(int id, [FromBody] string genre)
        {
            //string yerine Genre entities oluşturulacak. O nesne buraya verilecek.value değerleriküçük.
        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{id}")]
        public void DeleteGenre(int id)
        {
        }
    }
}
