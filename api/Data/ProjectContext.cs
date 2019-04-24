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

        public DbSet<Item> Item { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Place> Place { get; set; }
        public DbSet<Trail> Trail {get; set;}
        public DbSet<Trip> Trip { get; set; }
    }
}
