using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TEST.Models;

namespace TEST.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    public DbSet<Person> Persons { get; set; }
    public DbSet<TEST.Models.Employee> Employee { get; set; } = default!;
}