using MustafaEraslanGraduationProject.Entities;
using Newtonsoft.Json;

namespace MustafaEraslanGraduationProject.Service.Imp
{
    public class GenresService : IGenreService

    {
        private readonly MoviesContext _context;
        public GenresService(MoviesContext context)
        {
            _context = context;
        }
        public void AddGenre(long movieId, Genres genre)
        {
            // throw new NotImplementedException();
            var mytable = _context.Mytables.Where(x => x.Id == movieId).FirstOrDefault();
            if (mytable != null)
            {
                List<Genres> genres = new List<Genres>();
                if (string.IsNullOrWhiteSpace(mytable.Genres))
                {
                    genres.Add(genre);
                    var genreSerialize = JsonConvert.SerializeObject(genres);
                    mytable.Genres = genreSerialize;
                }
                else
                {
                    var temp = JsonConvert.DeserializeObject<List<Genres>>(mytable.Genres);
                    if (temp != null)
                    {
                        temp.Add(genre);
                        genres = temp;
                    }
                    var genreSerialize = JsonConvert.SerializeObject(genres);
                    mytable.Genres = genreSerialize;

                }
               
                _context.Add(mytable);
                _context.SaveChanges();
            }
        }

        public void DeleteByMovieAllGenre(long movieId)
        {
            throw new NotImplementedException();
        }

        public void DeleteGenre(long movieId, int genreId)
        {
            throw new NotImplementedException();
        }

        public List<Genres> ListGenres(long movieId)
        {
            var mytable = _context.Mytables.Where(x => x.Id == movieId).FirstOrDefault();
            if(mytable != null && !string.IsNullOrWhiteSpace(mytable.Genres))
            {
                var genres = JsonConvert.DeserializeObject<List<Genres>>(mytable.Genres);
                if (genres != null) return genres;
                return new List<Genres>();
            }
            else
            {
                return new List<Genres>();
            }
        }

        public void UpdateGenre(long movieId, int genreId, Genres genre)
        {
            throw new NotImplementedException();
        }
    }
}
