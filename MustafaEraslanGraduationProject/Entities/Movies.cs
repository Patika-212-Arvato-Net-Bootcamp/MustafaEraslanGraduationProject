using System.ComponentModel.DataAnnotations;

namespace MustafaEraslanGraduationProject.Entities
{
    public class Movies
    {
        [MaxLength(5000)]
        public char? adult { get; set; }

        [MaxLength(5000)]
        public char? belongs_to_collection { get; set; }
        public long? budget { get; set; }
        [MaxLength(5000)]
        public char? genres { get; set; }
        [MaxLength(5000)]
        public char? homepage { get; set; }
 
        public int id { get; set; }
        [MaxLength(5000)]
        public char? imdb_id { get; set; }
        [MaxLength(5000)]
        public char? original_language { get; set; }
        [MaxLength(5000)]
        public char? original_title { get; set; }
        [MaxLength(5000)]
        public char? overview { get; set; }

        public decimal? popularity { get; set; }
        [MaxLength(5000)]
        public char? poster_path { get; set; }
        [MaxLength(5000)]
        public char? production_companies { get; set; }
        [MaxLength(5000)]
        public char? production_countries { get; set; }
        [MaxLength(5000)]
        public char? release_date { get; set; }
  
        public int? revenue { get; set; }

        public decimal? runtime { get; set; }
        [MaxLength(5000)]
        public char? spoken_languages { get; set; }
        [MaxLength(5000)]
        public char? status { get; set; }
        [MaxLength(5000)]
        public char? tagline { get; set; }
        [MaxLength(5000)]
        public char? title { get; set; }
        [MaxLength(5000)]
        public char? video { get; set; }

        public decimal? vote_average { get; set; }

        public long? vote_count { get; set; }



    }
}
