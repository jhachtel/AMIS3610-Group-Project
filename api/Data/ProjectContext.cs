using Microsoft.EntityFrameworkCore;
using AMIS3610.GroupProject.Api.Models;
using AMIS3610.GroupProject.Api;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AMIS3610.GroupProject.Api.Data

{
    public class ProjectContext : IdentityDbContext<ApplicationUser>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);

        public DbSet<Gear> Gear { get; set; }
        public DbSet<Place> Place { get; set; }
    }
}
