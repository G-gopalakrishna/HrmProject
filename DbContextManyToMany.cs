using Microsoft.EntityFrameworkCore;


namespace ManyToManyRelagtion.Models.DbContextManyToMany
{
    public class DbContextManyToMany : DbContext
    {
        public DbContextManyToMany(DbContextOptions<DbContextManyToMany> dbContext) : base(dbContext)
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasKey(e => new { e.StudentID, e.CourseID });
            //configure the many to many relationship
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .Hasforeignkey(e => e.studentId);
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(s => s.Enrollments)
                .Hasforeignkey(e => e.courseId);
        }
    }
}
    
