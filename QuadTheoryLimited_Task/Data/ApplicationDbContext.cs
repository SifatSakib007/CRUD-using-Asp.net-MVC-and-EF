using Microsoft.EntityFrameworkCore;
using QuadTheoryLimited_Task.Models;

namespace QuadTheoryLimited_Task.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Class> Class { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().HasData(
                    new Class { Id = 1, Name = "Class 1" },
                    new Class { Id = 2, Name = "Class 2" },
                    new Class { Id = 3, Name = "Class 3" },
                    new Class { Id = 4, Name = "Class 4" },
                    new Class { Id = 5, Name = "Class 5" },
                    new Class { Id = 6, Name = "Class 6" },
                    new Class { Id = 7, Name = "Class 7" },
                    new Class { Id = 8, Name = "Class 8" },
                    new Class { Id = 9, Name = "Class 9" },
                    new Class { Id = 10, Name = "Class 10" }
);  
        }
    }
}
