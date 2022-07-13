using System.ComponentModel.DataAnnotations;

namespace MustafaEraslanGraduationProject.Entities
{
    [Serializable]
    public class Genres
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
