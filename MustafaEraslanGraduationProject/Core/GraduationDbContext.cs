using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MustafaEraslanGraduationProject.Entities;
using MustafaEraslanGraduationProject.Entities.IdentityAuth;

namespace MustafaEraslanGraduationProject.Core
{
    public class GraduationDbContext : IdentityDbContext<GraduationUser, GraduationRole, int>
    {
        public GraduationDbContext(DbContextOptions<GraduationDbContext> dbContext) : base(dbContext)
        {
        }

        public DbSet<Movies> mytable { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
