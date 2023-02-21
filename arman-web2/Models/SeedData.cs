using Microsoft.EntityFrameworkCore;

namespace arman_web2.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            ApplicationDbContext con = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            con.Database.Migrate();
            if (!con.Comments.Any()) 
            {
                con.Comments.AddRange(
                    new Comment() { name = "Arman", message = "Excellent Website. Congratulations!!", creation_date = DateTime.Now },
                    new Comment() { name = "Zorman", message = "Perfect idea. Good Job.", creation_date = DateTime.Now }
                    );
                con.SaveChanges();
            }

        }
    }
}
