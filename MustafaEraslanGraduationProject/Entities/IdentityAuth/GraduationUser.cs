using Microsoft.AspNetCore.Identity;

namespace MustafaEraslanGraduationProject.Entities.IdentityAuth
{
    public class GraduationUser : IdentityUser<int>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserType { get; set; }
    }
}
