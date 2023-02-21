using Microsoft.EntityFrameworkCore;

namespace arman_web2.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

    }
}
