using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UniversityRegistrar.Models
{
  public class UniversityRegistrarContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Student> Students { get; set; }

    public DbSet<Course> Courses {get; set;}

    public DbSet<CourseStudent> CourseStudents {get; set;}

    public UniversityRegistrarContext(DbContextOptions options) : base(options) { }
  }
}