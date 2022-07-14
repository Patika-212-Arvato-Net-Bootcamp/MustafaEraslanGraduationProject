using MustafaEraslanGraduationProject.Entities;
using Newtonsoft.Json;

namespace MustafaEraslanGraduationProject.Service.Imp
{
    public class MovieService : IMovieService
    {
        private readonly MoviesContext _context;

        public MovieService(MoviesContext context)
        {
            _context = context;
        }

        public void AddMovie(Mytable movie)
        {
            Genres genre = new Genres();
            List<Genres> genres = new List<Genres>();
            if (string.IsNullOrWhiteSpace(movie.Genres))
            {
                movie.Genres = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.SpokenLanguages))
            {
                movie.SpokenLanguages = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                movie.ProductionCompanies = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                movie.ProductionCompanies = "[]";
            }

            _context.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(long id)
        {
            var movie= _context.Mytables.Where(x => x.Id == id).FirstOrDefault();
            if(movie != null)
            {
                _context.Remove(movie);
                _context.SaveChanges();
            }
        }

        public Mytable GetMovieDetail(long id)
        {
            throw new NotImplementedException();
        }

        public List<Mytable> GetMovieList(int genreId)
        {
            throw new NotImplementedException();
        }

        public List<Mytable> GetMovieList(float rateFilter)
        {
            throw new NotImplementedException();
        }

        public List<Mytable> GetMovieList(DateTime releaseDate)
        {
            throw new NotImplementedException();
        }

        public List<Mytable> Search(string title)
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(long id, Mytable movie)
        {
            throw new NotImplementedException();
        }
    }
}
