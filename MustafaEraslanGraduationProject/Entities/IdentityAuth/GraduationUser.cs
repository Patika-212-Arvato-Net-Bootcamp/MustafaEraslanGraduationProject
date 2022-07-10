using Microsoft.AspNetCore.Identity;

namespace MustafaEraslanGraduationProject.Entities.IdentityAuth
{
    public class GraduationUser : IdentityUser<int>
    {
        public string Name { get; set; }

        public string Suname { get; set; }

        public string UserType { get; set; }
    }
}
