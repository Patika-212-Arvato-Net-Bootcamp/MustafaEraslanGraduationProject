using Microsoft.AspNetCore.Mvc;
using MustafaEraslanGraduationProject.Entities;
using MustafaEraslanGraduationProject.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MustafaEraslanGraduationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrendingController : ControllerBase
    {
        private ITrendingService _trendingService;
        public TrendingController(ITrendingService trendingService)
        {
            _trendingService = trendingService;
        }
        // GET: api/<TrendingController>
        [HttpGet]
        public List<Mytable> ListMostViewedMovies()
        {
            return _trendingService.ListMostViewedMovies();
        }

        // GET api/<TrendingController>
        [HttpGet]
        public List<Mytable> ListTopRatedMovies()
        {
            return _trendingService.ListTopRatedMovies();
        }

    }
}
