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
                var movieS = movie.Genres;
                movieS = genreSerialize;
            }
            else
            {
                var movieY = movie.Genres;
                var temp = JsonConvert.DeserializeObject<List<Genres>>(movieY);
                if (temp != null)
                {
                    temp.Add(genre);
                    genres = temp;
                }
                var genreSerialize = JsonConvert.SerializeObject(genres);
                var movieS = movie.Genres;
                movieS = genreSerialize;
            }

            BelongsToCollection belong = new BelongsToCollection();
            if (string.IsNullOrWhiteSpace(movie.BelongsToCollection))
            {
                var belon = new BelongsToCollection()
                {
                    Id = belong.Id,
                    Name = belong.Name,
                    BackDrop_Path = belong.BackDrop_Path,
                    Poster_Path = belong.Poster_Path
                };
                var genreSerialize = JsonConvert.SerializeObject(belon);
                var belongS = movie.BelongsToCollection;
                belongS = genreSerialize;
            }
            else
            {
                var belongY = movie.BelongsToCollection;
                var temp = JsonConvert.DeserializeObject<BelongsToCollection>(belongY);
                if (temp != null)
                {
                    var belon = new BelongsToCollection()
                    {
                        Id = belong.Id,
                        Name = belong.Name,
                        BackDrop_Path = belong.BackDrop_Path,
                        Poster_Path = belong.Poster_Path
                    };
                    belon = temp;
                }
                var genreSerialize = JsonConvert.SerializeObject(belongY);
                var belongS = movie.BelongsToCollection;
                belongS = genreSerialize;
            }

            SpokenLanguages language = new SpokenLanguages();
            List<SpokenLanguages> languages = new List<SpokenLanguages>();
            if (string.IsNullOrWhiteSpace(movie.SpokenLanguages))
            {
                languages.Add(language);
                var genreSerialize = JsonConvert.SerializeObject(languages);
                var languageS = movie.SpokenLanguages;
                languageS = genreSerialize;
            }
            else
            {
                var languageY = movie.SpokenLanguages;
                var temp = JsonConvert.DeserializeObject<List<SpokenLanguages>>(languageY);
                if (temp != null)
                {
                    temp.Add(language);
                    languages = temp;
                }
                var genreSerialize = JsonConvert.SerializeObject(languages);
                var movieS = movie.SpokenLanguages;
                movieS = genreSerialize;
            }

            ProductionCompanies company = new ProductionCompanies();
            List<ProductionCompanies> companies = new List<ProductionCompanies>();
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                companies.Add(company);
                var genreSerialize = JsonConvert.SerializeObject(companies);
                var companyS = movie.ProductionCompanies;
                companyS = genreSerialize;
            }
            else
            {
                var companyY = movie.ProductionCompanies;
                var temp = JsonConvert.DeserializeObject<List<ProductionCompanies>>(companyY);
                if (temp != null)
                {
                    temp.Add(company);
                    companies = temp;
                }
                var genreSerialize = JsonConvert.SerializeObject(companies);
                var movieS = movie.ProductionCompanies;
                movieS = genreSerialize;
            }


            ProductionCountries country = new ProductionCountries();
            List<ProductionCountries> countries = new List<ProductionCountries>();
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies.ToString()))
            {
                countries.Add(country);
                var genreSerialize = JsonConvert.SerializeObject(countries);
                var countryS = movie.ProductionCountries;
                countryS = genreSerialize;
            }
            else
            {
                var countryY = movie.ProductionCountries;
                var temp = JsonConvert.DeserializeObject<List<ProductionCountries>>(countryY);
                if (temp != null)
                {
                    temp.Add(country);
                    countries = temp;
                }
                var genreSerialize = JsonConvert.SerializeObject(countries);
                var movieS = movie.ProductionCountries;
                movieS = genreSerialize;
            }


            _context.Mytables.Add(movie);
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
