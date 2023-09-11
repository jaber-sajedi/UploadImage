using Microsoft.EntityFrameworkCore;
using UploadImageInAsp.netCore.Models;

namespace UploadImageInAsp.netCore.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, Name = "jaber", ImageUrl = ""},
                new User {Id = 2, Name = "jaber", ImageUrl = ""},
                new User {Id = 3, Name = "jaber", ImageUrl = ""}
            );
        }
    }
}
