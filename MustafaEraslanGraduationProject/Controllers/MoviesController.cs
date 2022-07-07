using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MustafaEraslanGraduationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // GET: api/<Movies>
        [HttpGet]
        public IEnumerable<string> GetMovieDetail()
        {
            return new string[] { "" };
        }

        // GET api/<Movies>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Movies>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Movies>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
