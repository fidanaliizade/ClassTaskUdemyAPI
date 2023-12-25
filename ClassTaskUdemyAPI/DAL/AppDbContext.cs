using ClassTaskUdemyAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassTaskUdemyAPI.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) :base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<StudentsCourses> StudentsCourses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
          .HasOne(s => s.Parent)
          .WithMany(m => m.Children)
          .HasForeignKey(e => e.ParentId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
