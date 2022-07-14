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
                genres.Add(genre);
                var genreSerialize = JsonConvert.SerializeObject(genres);
                movie.Genres = genreSerialize;
            }
            else
            {
                var temp = JsonConvert.DeserializeObject<List<Genres>>(movie.Genres);
                if (temp != null)
                {
                    temp.Add(genre);
                    genres = temp;
                }
                var genreSerialize = JsonConvert.SerializeObject(genres);
                movie.Genres = genreSerialize;
            }

            BelongsToCollection belong = new BelongsToCollection();
            List<BelongsToCollection> belongs = new List<BelongsToCollection>();
            if (string.IsNullOrWhiteSpace(movie.BelongsToCollection))
            {
                belongs.Add(belong);
                var genreSerialize = JsonConvert.SerializeObject(belongs);
                movie.BelongsToCollection = genreSerialize;
            }
            else
            {
                var temp = JsonConvert.DeserializeObject<List<BelongsToCollection>>(movie.BelongsToCollection);
                if (temp != null)
                {
                    temp.Add(belong);
                    belongs = temp;
                }
                var genreSerialize = JsonConvert.SerializeObject(belongs);
                movie.BelongsToCollection = genreSerialize;
            }

            _context.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(long id)
        {
            throw new NotImplementedException();
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
