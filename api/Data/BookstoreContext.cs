using Microsoft.EntityFrameworkCore;
using AMIS3610.GroupProject.Api.Models;
using AMIS3610.GroupProject.Api;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AMIS3610.GroupProject.Api.Data

{
    public class BookstoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
