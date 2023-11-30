namespace ASP.NET_MVC.Models;

using Microsoft.EntityFrameworkCore;


public class ApplicationDbContext : DbContext {

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }
    public object Subjects { get; internal set; }
}
